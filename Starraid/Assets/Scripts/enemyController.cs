using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour
{

	// Create variable to track health
	public float Health;
	
	// Use this for initialization
	void Start ()
	{
		// Gives the enemy some health to start with
		Health = 100;
	}
	
	// Update is called once per frame
	void Update () {
		// Checks if the enemy has run out of health
		if (Health <= 0)
		{
			// If the enemy has run out of health, the enemy is destroyed
			Destroy(gameObject);
		}
	}

	// Triggered when the enemy hits a collider
	void OnTriggerEnter2D(Collider2D other)
	{
		// Checks what the enemy hit was a bullet
		if (other.gameObject.CompareTag("Bullet"))
		{
			// If the enemy hit a bullet, 10 health is subtracted
			Health -= 10;
		}
	}
}
