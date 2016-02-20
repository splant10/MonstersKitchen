using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Cauldron : MonoBehaviour, Interactable {
    public void Interact(GameObject interactor)
    {
		//handles Order Completion
		Debug.Log("Yo, we haven't implemented cooking yet.");
		if (interactor.GetComponent<PlayerController> ().listOfOrders.orders.Count > 0) {
			Order order = interactor.GetComponent<PlayerController> ().listOfOrders.orders.Peek ();
		
			List<Ingredient.ID> inventory = interactor.GetComponent<PlayerController> ().inventory.ingredients;
			int numCorrectIDs = 0;

			for (int i = 0; i < order.ingredients.Count; ++i) {
				if (interactor.GetComponent<PlayerController> ().inventory.Contains (order.ingredients [i])) {
					numCorrectIDs += 1;
				}
				if (numCorrectIDs == order.ingredients.Count) {
					// Order is Correct do something

					// Remove Order from Queue
					interactor.GetComponent<PlayerController> ().listOfOrders.orders.Dequeue ();
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
