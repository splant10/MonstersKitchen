using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OrderBlock : MonoBehaviour {
    private Order order;
    public Text orderNameText;
    public Text ingredientsText;

    public void SetOrder(Order order)
    {
        this.order = order;
        if (order != null)
        {
            orderNameText.text = order.ToString();
            ingredientsText.text = "";
            foreach (Ingredient.ID id in order.ingredients)
            {
                ingredientsText.text += Ingredient.Name(id) + "\n";
            }
        } else
        {
            orderNameText.text = "";
            ingredientsText.text = "";
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
