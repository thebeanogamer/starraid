using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetMainMenu : MonoBehaviour
{

	public GameObject mainMenu;
	public GameObject optionsMenu;
	public GameObject audioMenu;
	public GameObject difficultyMenu;
	public GameObject videoMenu;
	
	
	// Use this for initialization
	void Start ()
	{
		mainMenu.SetActive(true);
		optionsMenu.SetActive(false);
		audioMenu.SetActive(false);
		difficultyMenu.SetActive(false);
		videoMenu.SetActive(false);
		
	}
}
