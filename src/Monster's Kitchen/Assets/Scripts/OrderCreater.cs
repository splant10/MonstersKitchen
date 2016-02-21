﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OrderCreater : MonoBehaviour {
	public Recipe[] allRecipes; 
	public Order FirstOrder; // just a stand in
	public PlayerController player;
    private float lastOrderTime;
    public OrderList orderList;

    public float timeBetweenOrders;
    public float firstOrderTime;

	public OrderCreater(){

		allRecipes = new Recipe[5];
		List<Ingredient.ID> ingredientIDs;

		ingredientIDs = new List<Ingredient.ID>(new Ingredient.ID[] { Ingredient.ID.FLOUR, Ingredient.ID.SUGAR, Ingredient.ID.EGGS});
		allRecipes[0] = new Recipe(0, "CauldronCakes", 30, ingredientIDs);

		ingredientIDs = new List<Ingredient.ID>(new Ingredient.ID[] { Ingredient.ID.SUGAR, Ingredient.ID.EGGS});
        allRecipes[1] = new Recipe(1, "Murangueei", 30, ingredientIDs);

		ingredientIDs = new List<Ingredient.ID> (new Ingredient.ID[] {
			Ingredient.ID.OGREEGG,
			Ingredient.ID.EGGS,
			Ingredient.ID.FLOUR
		});
		allRecipes [2] = new Recipe (2, "OgreEgg Quiche", 30, ingredientIDs);

		ingredientIDs = new List<Ingredient.ID> (new Ingredient.ID[] {
			Ingredient.ID.SUGAR,
			Ingredient.ID.STARFISHBLOOD,
			Ingredient.ID.SPIDEREYE
		});
		allRecipes [3] = new Recipe (3, "Blood Jello", 30, ingredientIDs);

		ingredientIDs = new List<Ingredient.ID>(new Ingredient.ID[] { Ingredient.ID.FLOUR, Ingredient.ID.SPIDEREYE, Ingredient.ID.EGGS});
		allRecipes [4] = new Recipe (4, "Spider Eye pudding", 30, ingredientIDs);

	}
	// Use this for initialization
	void Start () {
        lastOrderTime = Time.time  - (timeBetweenOrders - firstOrderTime);
	}
	
	// Update is called once per frame
	void Update () {
		if (lastOrderTime + timeBetweenOrders < Time.time)
        {
            orderList.AddOrder(OrderAlgorithm());
            lastOrderTime = Time.time;
        }
	}

	public Order OrderAlgorithm (){
        return new Order(allRecipes[Random.Range(0, allRecipes.Length)]);
	}

}
