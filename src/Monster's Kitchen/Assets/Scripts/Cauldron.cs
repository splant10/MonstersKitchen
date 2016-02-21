using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Cauldron : MonoBehaviour, Interactable {
    public void Interact(GameObject interactor)
    {
		//handles Order Completion
		Debug.Log("Yo, we haven't implemented cooking yet.");
        OrderList orderList = interactor.GetComponent<PlayerController>().listOfOrders;

		if (!orderList.IsEmpty()) {
			Order order = orderList.Peek ();
		
			List<Ingredient.ID> inventory = interactor.GetComponent<PlayerController> ().inventory.ingredients;
			int numCorrectIDs = 0;

			for (int i = 0; i < order.ingredients.Count; ++i) {
				if (interactor.GetComponent<PlayerController> ().inventory.Contains (order.ingredients [i])) {
					numCorrectIDs += 1;
				}
				if (numCorrectIDs == order.ingredients.Count) {
					// Order is Correct do something

					// Remove Order from Queue
					orderList.PopOrder();
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
