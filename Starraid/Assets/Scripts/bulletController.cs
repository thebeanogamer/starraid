using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class bulletController : MonoBehaviour
{

	private Rigidbody2D rb2d;

	public float bulletSpeed;

	public float bulletLife;
	
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		rb2d.velocity = transform.right * bulletSpeed;
		Destroy(gameObject, bulletLife);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Wall"))
		{
			Destroy(gameObject);
		} 
	}
}
