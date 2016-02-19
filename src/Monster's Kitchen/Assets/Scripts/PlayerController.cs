using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    public int horizontalSpeed;
    public int jumpSpeed;

    private bool onGround;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        Rigidbody2D rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        float vertVel = rigidbody2D.velocity.y;
        float horizVel = 0.0f;

        if (Input.GetAxis("Horizontal") < 0)
        { // move left
            horizVel = -horizontalSpeed;
        } else if (Input.GetAxis("Horizontal") > 0)
        { // move right
            horizVel = horizontalSpeed;
        }

        if (Input.GetAxis("Vertical") > 0 && IsGrounded())
        {
            vertVel = jumpSpeed;
            onGround = false;
        }
        rigidbody2D.velocity = new Vector2(horizVel, vertVel);
    }

    public bool IsGrounded()
    {
        return onGround;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D rigidbody2D = gameObject.GetComponent<Rigidbody2D>();

        if (collision.transform.position.y < rigidbody2D.transform.position.y)
        {
            onGround = true;
        }
    }
}
