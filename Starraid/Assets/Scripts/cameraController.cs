using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
	// Code created with the help of Unity documentation: https://unity3d.com/learn/tutorials/projects/2d-ufo-tutorial/following-player-camera
	
	// Public variable to store the player game object
	public GameObject player;

	// Stores the offset between the player and the camera
	private Vector3 offset;
	
	// Use this for initialization
	void Start ()
	{
		// Calculates the ammount the camera needs to move to align with the player
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate ()
	{
		// Moves the camera to align with the player using the already calculated offset
		transform.position = player.transform.position + offset;
	}
}
