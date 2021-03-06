﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Order {
	private float startTime;
	private Recipe recipe;
	private List<Ingredient> ingredients;
    private List<Ingredient.ID> requiredIngredients;
	private int id;

    private List<OrderListener> listeners;

	public Order(Recipe newRecipe) {
		this.recipe = newRecipe;
		this.ingredients = new List<Ingredient>();
        this.requiredIngredients = newRecipe.GetIngredients();
        this.listeners = new List<OrderListener>();
		this.id = 0;
        startTime = Time.time;
	}

	public bool IsExpired (){
		return (TimeRemaining() <=0 );
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
            NotifyListeners();
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

    public void AddListener(OrderListener listener)
    {
        listeners.Add(listener);
    }

    public void RemoveListener(OrderListener listener)
    {
        listeners.Remove(listener);
    }

    private void NotifyListeners()
    {
        foreach (OrderListener listener in listeners)
        {
            listener.OrderUpdated(this);
        }
    }
}
