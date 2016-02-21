using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Order {
	private float startTime;
	private Recipe recipe;
	private List<Ingredient> ingredients;
    private List<Ingredient.ID> requiredIngredients;
	private int id;

	public Order(Recipe newRecipe) {
		this.recipe = newRecipe;
		this.ingredients = new List<Ingredient>();
        this.requiredIngredients = new List<Ingredient.ID>();
        requiredIngredients = newRecipe.GetIngredients();
		this.id = 0;
        startTime = Time.time;
	}

	public bool IsExpired (){
		return (startTime - Time.time >= recipe.GetTimeLimit ());
	}

	public float TimeRemaining(){
		return ((recipe.GetTimeLimit() + startTime) - Time.time);
	}

    public override string ToString()
    {
        return recipe.ToString();
    }

    public bool AddIngredient(Ingredient ingredient)
    {
        if (recipe.Contains(ingredient.getID()) && !ingredients.Contains(ingredient)) {
            Debug.Log("Added " + ingredient + " to Order of " + this);
            ingredients.Add(ingredient);
            requiredIngredients.Remove(ingredient.getID());
            return true;
        }
        return false;
    }

    public Recipe GetRecipe()
    {
        return recipe;
    }

    public List<Ingredient> GetAddedIngredients()
    {
        return ingredients;
    }

    public List<Ingredient.ID> GetRequiredIngredients()
    {
        return requiredIngredients;
    }

    public bool Complete()
    {
        return requiredIngredients.Count == 0;
    }
}
