using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.UI;

public class fullScreenOptions : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// Created with the help of https://docs.unity3d.com/ScriptReference/QualitySettings.GetQualityLevel.html
		
		// Creates a variable to store the current visual quality level, and then retrives and stores it
		bool currentFullScreen = Screen.fullScreen;

		// Creates a variable to store the dropdown menu this script is attached to, then retrives the component to fill the variable.
		Toggle toggle = GetComponent<Toggle>();
		
		// Sets the value of the dropdown to the current visual quality level
		toggle.isOn = currentFullScreen;
	}
	
	public void switchFullScreen ()
	{
		// Created with the help of https://docs.unity3d.com/ScriptReference/Screen-fullScreen.html

		// Toggles fullscreen
		Screen.fullScreen = !Screen.fullScreen;

	}
}
