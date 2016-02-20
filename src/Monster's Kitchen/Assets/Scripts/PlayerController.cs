using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    public float horizontalSpeed;
    public float jumpSpeed;

    public Transform bottom;

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
        return Physics2D.Linecast(bottom.position, (Vector2)bottom.position + (0.1f * Vector2.down));
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Rigidbody2D rigidbody2D = gameObject.GetComponent<Rigidbody2D>();

        if (other.gameObject.layer.ToString().Equals("Ground"))
        {
            onGround = true;
        }
    }
}
