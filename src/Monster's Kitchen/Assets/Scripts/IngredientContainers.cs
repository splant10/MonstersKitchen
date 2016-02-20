using UnityEngine;
using System.Collections;

public class IngredientContainers : MonoBehaviour, Interactable {
	public Ingredient.ID ingredient;

	public void Interact(GameObject interactor){
		// give interactor inventory one ingredient

		for (int i = 0; i <= interactor.GetComponent<PlayerController>().inventory.capacity; ++i) {
			if (interactor.GetComponent<PlayerController>().inventory.ingredients[i].Equals(ingredient)) {
				// make them stack
				// TODO
				break;
			}
			if (interactor.GetComponent<PlayerController>().inventory.ingredients[i] == Ingredient.ID.NONE) {
				interactor.GetComponent<PlayerController>().inventory.ingredients[i] = ingredient;
				Debug.Log ("added ingredient to inventory");
				break;
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
