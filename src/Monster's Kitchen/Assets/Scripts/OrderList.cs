using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class OrderList : MonoBehaviour {
	private List <Order> orders;
	public float timeLimit;
    public OrderBlock[] orderBlocks;

    public Text hudFailedCount;
    private int ordersFailedCount = 0;

	public OrderList(){
		orders = new List<Order>();
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	// Here we handle Order drawing
	void Update () {
		for (int i = 0; i < orders.Count; ++i) {
            Order order = orders[i];
            timeLimit = order.TimeRemaining();
            if (order.TimeRemaining() <= 0)
            {
                orders.Remove(order);
                ++ordersFailedCount;
                hudFailedCount.text = "Orders Failed: " + ordersFailedCount;
                break;
            }
		}

        int j = 0;
        foreach (Order order in orders)
        {
            if (j > orderBlocks.Length)
            {
                break;
            }
            orderBlocks[j].SetOrder(order);
            ++j;
        }
        orderBlocks[j].SetOrder(null);

    }

	public void AddOrder(Order order){
        if (orders.Count < orderBlocks.Length)
        {
            orderBlocks[orders.Count].SetOrder(order);
        }
		orders.Add(order);
	}

    public Order PopOrder()
    {
        Order returnOrder = orders[0];
        orders.RemoveAt(0);
        int i = 0;
        orderBlocks[0].SetOrder(null);
        foreach (Order order in orders)
        {
            if (i > orderBlocks.Length)
            {
                break;
            }
            orderBlocks[i].SetOrder(order);
            ++i;
        }

        if (i < orderBlocks.Length)
        {
            orderBlocks[i].SetOrder(null);
        }
        return returnOrder;
    }

    public Order Peek()
    {
        return orders[0];
    }

    public bool IsEmpty()
    {
        return orders.Count == 0;
    }

}