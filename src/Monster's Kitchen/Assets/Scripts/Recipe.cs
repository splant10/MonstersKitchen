using UnityEngine;
using System.Collections;

public class Recipe : MonoBehaviour {

	private int id;
	private string name;
	private int timeLimit;
	private int[] ingredients = new int[4];

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
	
	}
}
