using UnityEngine;
using System.Collections;

public class OrderCreater : MonoBehaviour {
	public Recipe[] allRecipes; 
	public Order FirstOrder; // just a stand in
	public PlayerController player;

	public OrderCreater(){
		allRecipes = new Recipe[1];
		Ingredient.ID[] ingredientIDs = {Ingredient.ID.FLOUR, Ingredient.ID.SUGAR, Ingredient.ID.EGGS};
		allRecipes[0] = new Recipe(0, "CauldronCakes", 30, ingredientIDs);
		FirstOrder = new Order (allRecipes [0]);
	}
	// Use this for initialization
	void Start () {
		player.AddOrder (OrderAlgorithm());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public Order OrderAlgorithm (){
		return FirstOrder;
	}

}
