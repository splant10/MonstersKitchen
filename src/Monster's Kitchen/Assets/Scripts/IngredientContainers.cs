using UnityEngine;
using System.Collections;

public class IngredientContainers : MonoBehaviour, Interactable {
	public Ingredient.ID ingredient;

	public void Interact(GameObject interactor){
        // give interactor inventory one ingredient
        Inventroy playerInventory = interactor.GetComponent<PlayerController>().inventory;

		for (int i = 0; i <= playerInventory.InventorySize(); ++i) {
/*			if (playerInventory.Contains(ingredient)) {
				// make them stack
				// TODO
				break;
			}
			if () {*/
				playerInventory.Add(new Ingredient(ingredient));
				break;

		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
