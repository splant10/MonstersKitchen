using UnityEngine;
using System.Collections;

public class Recipe : MonoBehaviour {

	private int id;
	private string name;
	private int timeLimit;
	private int[] ingredients = new int[4];
	private int startTime;

	public Recipe (int id, string name, int timeLimit, int[] ingredients) {
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
		if (startTime - Time.time >= this.timeLimit) {
			// call some timeout function
		}
		// Display (startTime - Time.time) on the screen

		// Check if all recipe ingredients are in the caludron
			// if they are make the recipe bar green and make it disapear, Increment score

		// 
	}
}
