using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visualSettingsMenu : MonoBehaviour {

	// OnGUI is called when a UI element is rendered
	void OnGUI () {
		// Creates an array of strings and stores all avalible visual quality presets in it
		string[] names = QualitySettings.names;
		// Creates a vertical control group
		GUILayout.BeginVertical();
		int i = 0;
		while (i < names.Length) {
			if (GUILayout.Button(names[i]))
				QualitySettings.SetQualityLevel(i, true);
            
			i++;
		}
		GUILayout.EndVertical();
	}
	
}
