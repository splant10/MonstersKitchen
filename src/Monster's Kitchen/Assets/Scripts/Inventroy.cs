using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class Inventroy {
	public int capacity = 4;
	private List<Ingredient> ingredients;

	public Inventroy(){
		ingredients = new List<Ingredient> ();
	}

	public bool Contains(Ingredient.ID id){
		for (int i = 0; i < this.ingredients.Count; ++i) {
			if (this.ingredients[i].getID() == id) {
				return true;
			}
		}		
		return false;
	}

    public bool IsFull()
    {
        return ingredients.Count >= capacity;
    }

    public void Add(Ingredient ingredient)
    {
        if (!IsFull())
        {
            ingredients.Add(ingredient);
            Debug.Log("Picked up " + ingredient);
        } else
        {
            throw new InventroyFullException();
        }
    }

    public bool Remove(Ingredient.ID id)
    {
        for (int i = 0; i < this.ingredients.Count; ++i)
        {
            if (this.ingredients[i].getID() == id)
            {
                Debug.Log("Removed ingredient from inv: " + ingredients[i]);
                ingredients.Remove(ingredients[i]);
                return true;
            }
        }
        return false;
    }
}
