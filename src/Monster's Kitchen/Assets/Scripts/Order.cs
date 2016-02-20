using UnityEngine;
using System.Collections;

public class Order : MonoBehaviour {
	private int startTime;
	private Recipe recipe;
	private Ingredient[] ingredients;
	private int id;

	// Use this for initialization
	void Start () {
		startTime = Time.time; // Time.time = current time

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
	public int TimeRemaining(){
		return (startTime -Time.time)
	}
}
