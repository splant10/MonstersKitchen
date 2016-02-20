using UnityEngine;
using System.Collections;

public class Recipe : MonoBehaviour {

	private int id;
	private string name;
	private float timeLimit;
	public Ingredient.ID[] ingredients;

	public Recipe (int id, string name, int timeLimit, Ingredient.ID[] ingredients) {
		this.id = id;
		this.name = name;
		this.timeLimit = timeLimit;
		this.ingredients = ingredients;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		// 
	}

	public float GetTimeLimit() {
		return timeLimit;
	}
}
