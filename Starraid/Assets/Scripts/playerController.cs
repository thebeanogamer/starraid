using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

public class playerController : MonoBehaviour
{

	// Create variable using which the rigidbody 2d of the player can be accessed
	private Rigidbody2D rb2d;
	// Create public variable which can be used to set the speed at which the player moves
	public float Speed;
	// Create public variable to link to the bullet prefab
	public GameObject bulletPrefab;
	// Create private variable which stores the location of the player for bullet creation
	private Transform bulletSpawn;

	// Use this for initialization, this is called when the object is loaded
	void Start ()
	{
		// Binds the player's rigidbody to a variable
		rb2d = GetComponent<Rigidbody2D>();

		bulletSpawn = GetComponent<Transform>();
	}
	
	// FixedUpdate is called multiple times per frame, and is used for objects effected by physics
	void FixedUpdate ()
	{
		// Stores the current horizontal input in the float moveX, using raw input to prevent overshooting
		float moveX = Input.GetAxisRaw("Horizontal");
		
		// Stores the current vertical input in the float moveY, using raw input to prevent overshooting
		float moveY = Input.GetAxisRaw("Vertical");
		
		// Sets the velocity of the player to the two move values multiplied by the public variable "speed"
		rb2d.velocity = new Vector2(moveX*Speed,moveY*Speed);

	}
	
	// Update is called once per frame
	void Update() 
	{
		// Calculates the mouse position
		Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
		
		// Calculates the position for the player to be rotated to
		float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
		
		// Rotates the player to the calculated rotation
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

		if (Input.GetAxisRaw("Fire") == 1)
		{
			// Create the Bullet from the Bullet prefab, placing it under the player
			Instantiate (
				bulletPrefab,
				bulletSpawn.position + new Vector3(0,0,1),
				bulletSpawn.rotation);
		}
	}
}
