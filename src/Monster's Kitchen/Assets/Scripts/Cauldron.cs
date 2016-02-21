using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Cauldron : MonoBehaviour, Interactable {
    public void Interact(GameObject interactor)
    {
		//handles Order Completion
        OrderList orderList = interactor.GetComponent<PlayerController>().listOfOrders;

		if (!orderList.IsEmpty()) {
			Order order = orderList.Peek ();
		
			Inventroy inventory = interactor.GetComponent<PlayerController> ().inventory;
            List<Ingredient.ID> requiredIngredients = new List<Ingredient.ID>(order.GetRequiredIngredients());

			for (int i = 0; i < requiredIngredients.Count; ++i) {
				if (inventory.Contains(requiredIngredients[i]))
                {
                    inventory.Remove(requiredIngredients[i]);
                    order.AddIngredient(new Ingredient(requiredIngredients[i]));
				}
				if (order.Complete()) {
					// Remove Order from Queue
					orderList.PopOrder();
                    print("Completed order: " + order);
				}

			}
		}
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
