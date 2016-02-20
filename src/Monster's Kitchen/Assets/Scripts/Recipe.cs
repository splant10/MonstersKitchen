using UnityEngine;
using System.Collections;
using System.Collections.Generic;
 
public class Recipe {

	private int id;
	private string name;
	private float timeLimit;
	public List<Ingredient.ID> ingredients;

	public Recipe (int id, string name, int timeLimit, List<Ingredient.ID> ingredients) {
		this.id = id;
		this.name = name;
		this.timeLimit = timeLimit;
		this.ingredients = ingredients;
	}

	public float GetTimeLimit() {
		return timeLimit;
	}

    public override string ToString()
    {
        return name;
    }
}
