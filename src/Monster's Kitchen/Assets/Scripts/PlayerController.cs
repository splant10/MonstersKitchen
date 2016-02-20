using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    public float horizontalSpeed;
    public float jumpSpeed;
    public bool isGrounded;

    public Transform bottom;

    private bool recentlyInteracted;
    private bool facingRight;

	public OrderList ListOfOrders;
	public Inventroy inventory;

    private Rigidbody2D rb2d;
    private Animator anim;

	// Use this for initialization
	void Start () {
        facingRight = true;
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        Rigidbody2D rigidbody2D = GetComponent<Rigidbody2D>();
        float vertVel = rigidbody2D.velocity.y;
        float horizVel = 0.0f;

        if (Input.GetAxis("Horizontal") < 0)
        { // move left
            horizVel = -horizontalSpeed;
            if (facingRight)
            {
                SetFacingRight(false);
            }
            anim.SetFloat("Speed", horizontalSpeed);
        } else if (Input.GetAxis("Horizontal") > 0)
        { // move right
            horizVel = horizontalSpeed;
            if (!facingRight)
            {
                SetFacingRight(true);
            }
            anim.SetFloat("Speed", horizontalSpeed);
        } else
        {
            anim.SetFloat("Speed", 0);
        }
        if (IsGrounded())
        {
            if (Input.GetAxis("Vertical") > 0)
            {
                vertVel = jumpSpeed;
                anim.SetBool("isGrounded", false);
            } else
            {
                anim.SetBool("isGrounded", true);
            }
        }

		// handles order expiration
		if (ListOfOrders.orders.Count > 0 && ListOfOrders.orders.Peek().IsExpired()) {
			ListOfOrders.orders.Dequeue();
		}

        if (Input.GetAxis("Fire2") != 0 && !recentlyInteracted)
        {
            Interact();
            recentlyInteracted = true;
        } else if (Input.GetAxis("Fire2") == 0)
        {
            recentlyInteracted = false;
        }

        rigidbody2D.velocity = new Vector2(horizVel, vertVel);
        anim.SetFloat("VelY", vertVel);
	}
    
    public void SetFacingRight(bool flag)
    {
        facingRight = flag;
        // Multiply the player's x local scale by -1
        Vector2 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
    
    public bool IsGrounded()
    {
        return Physics2D.Linecast(bottom.position, (Vector2)bottom.position + (0.1f * Vector2.down), LayerMask.GetMask("Ground"));
    }
   
    public void Interact()
    {
        foreach (RaycastHit2D cast in Physics2D.LinecastAll(gameObject.transform.position, gameObject.transform.position))
        {
            Interactable interactable = cast.collider.gameObject.GetComponent<Interactable>();
            if (interactable != null)
            {
                interactable.Interact(gameObject);
            }
        }
    }

}
