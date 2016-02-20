using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class Inventroy {
	public int capacity = 4;
	public List<Ingredient.ID> ingredients;

	public Inventroy(){
		// initialize inventory with null spaces
		for (int i = 0; i < capacity; ++i) {
			ingredients[i] = Ingredient.ID.NONE;
		}
	}
	public bool Contains(Ingredient.ID id){
		for (int i = 0; i < this.ingredients.Count; ++i) {
			if (this.ingredients [i] == id) {
				return true;
			}
		}		
		return false;

		
	}
}
