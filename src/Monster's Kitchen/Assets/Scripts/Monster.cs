using UnityEngine;
using System.Collections;
using System;

public class Monster : MonoBehaviour, Attackable, Interactable {
    private bool isAlive;
    public Ingredient.ID ingredient;
    public AudioClip deathSound;
    public AudioClip pickupSound;
    private AudioSource source;

    // Use this for initialization
    void Start()
    {
        isAlive = true;
        source = gameObject.GetComponent<AudioSource>();
    }


    public void Attack(GameObject attacker)
    {
        gameObject.GetComponent<Animator>().SetBool("isAlive", false);
        if (isAlive)
        {
            source.PlayOneShot(deathSound);
        }
        isAlive = false;
    }

    public void Interact(GameObject interactor)
    {
        if (!isAlive)
        {
            interactor.GetComponent<PlayerController>().inventory.Add(new Ingredient(ingredient));
            source.PlayOneShot(pickupSound);
            Destroy(gameObject);
        }
    }

	// Update is called once per frame
	void Update () {
	
	}
}
