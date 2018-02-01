using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debugHandler : MonoBehaviour {

	public static void addLog(string message)
	{
		// Creates string with the current time & date, and the message sent to it by the calling method
		string output = "[" + DateTime.Now.Date + "] " + message;
		
		// Outputs the created string to the console
		Debug.Log(output);
	}
}
