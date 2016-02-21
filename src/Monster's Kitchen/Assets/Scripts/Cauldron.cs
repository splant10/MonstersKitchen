using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

public class Cauldron : MonoBehaviour, Interactable {

    public Text hudCount;
    private int orderCompletedCount;
    public AudioClip sploosh;
    private AudioSource source;

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
                    if (!order.IsExpired())
                    {
                        orderCompletedCount += 1;
                    }
					orderList.PopOrder();
                    print("Completed order: " + order);
                    hudCount.text = "Orders Completed: " + orderCompletedCount.ToString();
                    source = gameObject.GetComponent<AudioSource>();
                    source.PlayOneShot(sploosh);

                }

			}
		}
    }

    // Use this for initialization
    void Start () {
        orderCompletedCount = 0;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
