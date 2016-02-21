using UnityEngine;
using System.Collections;
using System;

public class Monster : MonoBehaviour, Attackable, Interactable {
    private bool isAlive;
    public Ingredient.ID ingredient;

    public void Attack(GameObject attacker)
    {
        gameObject.GetComponent<Animator>().SetBool("isAlive", false);
        isAlive = false;
    }

    public void Interact(GameObject interactor)
    {
        if (!isAlive)
        {
            interactor.GetComponent<PlayerController>().inventory.Add(new Ingredient(ingredient));
        }
    }

    // Use this for initialization
    void Start () {
        isAlive = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
