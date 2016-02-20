using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Order {
	private float startTime;
	private Recipe recipe;
	public List<Ingredient.ID> ingredients;
	private int id;

	public Order(Recipe newRecipe) {
		this.recipe = newRecipe;
		this.ingredients = newRecipe.ingredients;
		this.id = 0;
        startTime = Time.time;
	}

	public bool IsExpired (){
		return (startTime - Time.time >= recipe.GetTimeLimit ());
	}

	public float TimeRemaining(){
		return (startTime - Time.time);
	}
}
