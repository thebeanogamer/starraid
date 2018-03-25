using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour
{

	public float Health;
	
	// Use this for initialization
	void Start ()
	{
		Health = 100;
	}
	
	// Update is called once per frame
	void Update () {
		if (Health <= 0)
		{
			Destroy(gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		debugHandler.addLog("thing");
		if (other.gameObject.CompareTag("Bullet"))
		{
			Health -= 10;
		}
	}
}
