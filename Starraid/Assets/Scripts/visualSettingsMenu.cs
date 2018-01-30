using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class visualSettingsMenu : MonoBehaviour {

	// OnGUI is called when a UI element is rendered
	void OnGUI () {
		// Created with the help of: https://docs.unity3d.com/ScriptReference/UI.Dropdown.AddOptions.html, https://docs.unity3d.com/2018.1/Documentation/ScriptReference/QualitySettings.SetQualityLevel.html, and https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnGUI.html
		
		// Creates an array of strings and stores all avalible visual quality presets in it
		string[] names = QualitySettings.names;
		
		// Creates variable to store the dropdown being modified, and fetches the DropDown GameObject the script is attached to
		var m_Dropdown = GetComponent<Dropdown>();
		
		m_Dropdown.ClearOptions();

		Dropdown.OptionData m_NewData =  new Dropdown.OptionData();
		
		for (int i = 0; i <= names.Length; i++)
			m_NewData.text = "Option 1";
			//m_Messages.Add(m_NewData);
			m_Dropdown.AddOptions("hello");
		
		m_Dropdown.AddOptions(names);
	}
	
}
