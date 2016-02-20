using UnityEngine;
using System.Collections;

public class IngredientContainers : MonoBehaviour, Interactable {
	public Ingredient.ID ingredient;

	public void Interact(GameObject interactor){
        // give interactor inventory one ingredient
        Inventroy playerInventory = interactor.GetComponent<PlayerController>().inventory;

		for (int i = 0; i <= playerInventory.capacity; ++i) {
			if (playerInventory.ingredients[i].Equals(ingredient)) {
				// make them stack
				// TODO
				break;
			}
			if (playerInventory.ingredients[i] == Ingredient.ID.NONE) {
				playerInventory.ingredients[i] = ingredient;
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
