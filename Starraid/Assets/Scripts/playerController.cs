using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

	// Create variable using which the rigidbody 2d of the player can be accessed
	private Rigidbody2D rb2d;
	// Create public variable which can be used to set the speed at which the player moves
	public float SpeedMultiplier;

	// Use this for initialization, this is called when the object is loaded
	void Start ()
	{
		// Binds the player's rigidbody to a variable
		rb2d = GetComponent<Rigidbody2D>();
	}
	
	// FixedUpdate is called multiple times per frame, and is used for objects effected by physics
	void FixedUpdate ()
	{
		// Stores the current horizontal input in the float moveX, using raw input to prevent overshooting
		float moveX = Input.GetAxisRaw("Horizontal");
		
		// Stores the current vertical input in the float moveY, using raw input to prevent overshooting
		float moveY = Input.GetAxisRaw("Vertical");
		
		// Combines the two move values into movement, a vector2
		Vector2 movement = new Vector2(moveX,moveY);
		
		// Adds force to player to move them
		rb2d.AddForce(movement / (1/SpeedMultiplier), ForceMode2D.Impulse);

		// Locks the players rotation so they don't face the wrong direction
		rb2d.rotation = 0;

	}
}
