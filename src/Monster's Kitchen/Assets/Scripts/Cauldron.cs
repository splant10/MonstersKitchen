using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Cauldron : MonoBehaviour, Interactable {
    public void Interact(GameObject interactor)
    {
		//handles Order Completion
		Debug.Log("Yo, we haven't implemented cooking yet.");

		Order order = interactor.GetComponent<PlayerController> ().listOfOrders.orders.Peek();
		List<Ingredient> inventory = interactor.GetComponent<PlayerController> ().inventory.ingredients;
		int numCorrectIDs = 0;

		foreach (Ingredient.ID id in order.ingredients){
			if (inventory.Contains (id)) {
				numCorrectIDs += 1;
			}
			if (numCorrectIDs == order.ingredients) {
				// Order is Correct do something

				// Remove Order from Queue
				interactor.GetComponent<PlayerController>().listOfOrders.orders.Dequeue();
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
