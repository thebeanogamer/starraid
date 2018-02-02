using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class visualSettingsMenu : MonoBehaviour
{

	// Start is called when the element is first created
	void Start () {
		// Created with the help of https://docs.unity3d.com/ScriptReference/QualitySettings.GetQualityLevel.html
		
		// Creates a variable to store the current visual quality level, and then retrives and stores it
		int currentQuality = QualitySettings.GetQualityLevel();

		// Creates a variable to store the dropdown menu this script is attached to, then retrives the component to fill the variable.
		Dropdown dropdown = GetComponent<Dropdown>();
		
		// Sets the value of the dropdown to the current visual quality level
		dropdown.value = currentQuality;
		
		// Reports that the dropdown is ready to the console
		debugHandler.addLog("Quality dropdown ready");
	}

	public void setVisualQuality()
	{
		// Creates a variable to store the dropdown menu this script is attached to, then retrives the component to fill the variable.
		Dropdown dropdown = GetComponent<Dropdown>();
		
		// Sets the visual quality level to the one selected in the dropdown
		QualitySettings.SetQualityLevel(dropdown.value);
		
		// Reports the quality change to the console
		debugHandler.addLog("Visual quality changed to " + QualitySettings.GetQualityLevel());
	}
	
}