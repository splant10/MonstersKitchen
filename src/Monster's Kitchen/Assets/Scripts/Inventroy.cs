﻿using UnityEngine;
using System.Collections;

public class Inventroy {
	public Ingredient[] ingredients;
	public int capacity = 4;

	public Inventroy(){
		// initialize inventory with null spaces
		for (int i = 0; i < capacity; ++i) {
			ingredients[i] = null;
		}

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}