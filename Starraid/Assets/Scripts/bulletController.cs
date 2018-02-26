using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class bulletController : MonoBehaviour
{

	// Create variable using which the rigidbody 2d of the player can be accessed
	private Rigidbody2D rb2d;

	// Create variable to store desired speed of bullets
	public float bulletSpeed;

	// Create variable to store lifetime of bullets
	public float bulletLife;
	
	// Use this for initialization
	void Start () {
		// Stores the game object's rigidbody 2d in the created variable
		rb2d = GetComponent<Rigidbody2D>();
		// Sets the rigidbody 2d's velocity so the bullet moves
		rb2d.velocity = transform.right * bulletSpeed;
		// Destroys the game object after the set lifetime
		Destroy(gameObject, bulletLife);
	}

	// Triggeres when the bullet collides with another collider
	void OnTriggerEnter2D(Collider2D other)
	{
		// Checks if the object the bullet has collided with has the tag "Wall"
		if (other.gameObject.CompareTag("Wall"))
		{
			// If the object that the bullet collides with is a wall, the bullet deletes itself
			Destroy(gameObject);
		} 
	}
}
