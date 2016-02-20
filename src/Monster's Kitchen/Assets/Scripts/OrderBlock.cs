using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OrderBlock : MonoBehaviour {
    private Order order;
    public Text text;

    public void SetOrder(Order order)
    {
        this.order = order;
        text.text = order.ToString() ;
        Debug.Log(text.text);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
