using UnityEngine;
using System.Collections;

public class PlayerCharacter : MonoBehaviour 
{
	private Animator animator;
	
	private const float deadzone = 0.2f;
	
	private float horizontalInput, verticalInput;
	public bool facingRight = true;			// For determining which way the player is currently facing.
	private const float speed = 8.0f;
	
	void Start () 
	{
		animator = GetComponent<Animator>();
	}
	
	void Update () 
	{
		horizontalInput = Input.GetAxis("Horizontal");
		verticalInput = Input.GetAxis("Vertical");
		animator.SetFloat("HorizontalInput", horizontalInput);
		animator.SetFloat("VerticalInput", verticalInput);
		animator.SetFloat ("Speed", Mathf.Abs (horizontalInput));
		
		//bool canMoveHorizontally = horizontalInput > deadzone || horizontalInput < -deadzone;
		//bool canMoveVertically = verticalInput > deadzone || verticalInput < -deadzone;
	}

	void FixedUpdate ()
	{
		rigidbody2D.velocity = new Vector2 (horizontalInput * speed, verticalInput * speed);

		// If the input is moving the player right and the player is facing left...
		if(horizontalInput > 0 && !facingRight)
			// ... flip the player.
			Flip();
		// Otherwise if the input is moving the player left and the player is facing right...
		else if(horizontalInput < 0 && facingRight)
			// ... flip the player.
			Flip();
	}

	void Flip ()
	{
		// Switch the way the player is labelled as facing.
		facingRight = !facingRight;
		
		// Multiply the player's x local scale by -1.
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}