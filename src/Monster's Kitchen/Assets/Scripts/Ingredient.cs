using UnityEngine;
using System.Collections;

public class Ingredient {

	private ID id;
	private string name;

	public enum ID {FLOUR, SUGAR, EGGS}

	public Ingredient (ID id, string name) {
		this.id = id;
		this.name = name;
	}

	bool IsFlour() {
		return id == ID.FLOUR;
	}
}
