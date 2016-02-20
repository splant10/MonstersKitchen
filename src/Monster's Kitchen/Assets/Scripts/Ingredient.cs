using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Ingredient {

    private ID id;
    private string name;

    public enum ID {NONE, FLOUR, SUGAR, EGGS }
    private static Dictionary<ID, string> names;
    static Ingredient()
    {
        names = new Dictionary<ID, string>();
        names.Add(ID.FLOUR, "Flour");
        names.Add(ID.SUGAR, "Sugar");
        names.Add(ID.EGGS, "Eggs");
    }

	public Ingredient (ID id, string name) {
		this.id = id;
		this.name = name;
	}

	bool IsFlour() {
		return id == ID.FLOUR;
	}

	public override bool Equals(object ingredient) {
		return this.id == ((Ingredient)ingredient).id;
	}

    public static string Name(Ingredient.ID id)
    {
        return names[id];
    }
}
