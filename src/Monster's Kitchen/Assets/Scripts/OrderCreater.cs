using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OrderCreater : MonoBehaviour {
	public Recipe[] allRecipes; 
	public Order FirstOrder; // just a stand in
	public PlayerController player;
    private float lastOrderTime;
    public OrderList orderList;

	public OrderCreater(){

		allRecipes = new Recipe[2];
		List<Ingredient.ID> ingredientIDs;

		ingredientIDs = new List<Ingredient.ID>(new Ingredient.ID[] { Ingredient.ID.FLOUR, Ingredient.ID.SUGAR, Ingredient.ID.EGGS});
		allRecipes[0] = new Recipe(0, "CauldronCakes", 30, ingredientIDs);

		ingredientIDs = new List<Ingredient.ID>(new Ingredient.ID[] { Ingredient.ID.SUGAR, Ingredient.ID.EGGS});
        allRecipes[1] = new Recipe(1, "Murangueei", 30, ingredientIDs);
	}
	// Use this for initialization
	void Start () {
        lastOrderTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (lastOrderTime + 3 < Time.time)
        {
            orderList.AddOrder(OrderAlgorithm());
            lastOrderTime = Time.time;
        }
	}

	public Order OrderAlgorithm (){
        return new Order(allRecipes[Random.Range(0, allRecipes.Length)]);
	}

}
