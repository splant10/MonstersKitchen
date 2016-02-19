using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    public int horizontalSpeed;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        Rigidbody2D rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        float vertVel = rigidbody2D.velocity.y;
        float horizVel = 0.0f;

        if (Input.GetAxis("Horizontal") < -0.5)
        { // move left
            horizVel = -horizontalSpeed;
        } else if (Input.GetAxis("Horizontal") > 0.5)
        { // move right
            horizVel = horizontalSpeed;
        }
        rigidbody2D.velocity = new Vector2(-horizontalSpeed, rigidbody2D.velocity.y);
    }
}
