using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class OrderBlock : MonoBehaviour, OrderListener {
    private Order order;
    public Text orderNameText;
    public Text ingredientsText;
    public Text timeRemainingText;

    public void SetOrder(Order order)
    {
        this.order = order;
        if (order != null)
        {
            order.AddListener(this);
            orderNameText.text = order.ToString();
            ingredientsText.text = "";
            foreach (Ingredient ingredient in order.GetAddedIngredients())
            {
                ingredientsText.text += "✔" + ingredient + "\n";
            }
            foreach (Ingredient.ID id in order.GetRequiredIngredients())
            {
                ingredientsText.text += Ingredient.Name(id) + "\n";
            }
            timeRemainingText.text = string.Format("{0:f2}s", order.TimeRemaining());
        } else
        {
            orderNameText.text = "";
            ingredientsText.text = "";
            timeRemainingText.text = "";
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (order != null)
        {
            timeRemainingText.text = string.Format("{0:f2}s", order.TimeRemaining());
        }
    }

    public void OrderUpdated(Order o)
    {
        ingredientsText.text = "";
        foreach (Ingredient ingredient in order.GetAddedIngredients())
        {
            ingredientsText.text += "✔" + ingredient + "\n";
        }
        foreach (Ingredient.ID id in order.GetRequiredIngredients())
        {
            ingredientsText.text += Ingredient.Name(id) + "\n";
        }
    }
}
