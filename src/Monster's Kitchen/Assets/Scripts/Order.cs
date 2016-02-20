using UnityEngine;
using System.Collections;

public class Order : MonoBehaviour {
	private float startTime;
	private Recipe recipe;
	private Ingredient.ID[] ingredients;
	private int id;

	public Order(Recipe newRecipe) {
		this.recipe = newRecipe;
		this.ingredients = newRecipe.ingredients;
		this.id = 0;
	}

	// Use this for initialization
	void Start () {
		this.startTime = Time.time; // Time.time = current time


	}
	
	// Update is called once per frame
	void Update () {
		
		// Display (startTime - Time.time) on the screen

		// Check if all recipe ingredients are in the caludron
		// if they are make the recipe bar green and make it disapear, Increment score
	
	}
	public bool IsExpired (){
		return (startTime - Time.time >= recipe.GetTimeLimit ());
	}
	public float TimeRemaining(){
		return (startTime - Time.time);
	}
}
