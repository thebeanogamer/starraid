using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitOnClick : MonoBehaviour {

    public void Quit()
    {
        // Adds a note to the log stating the game has quit
        debugHandler.addLog("Quiting the game");
        
#if UNITY_EDITOR
        // Is only included if the game is compiled in the Unity Editor
        // Tells the Unity Editor to stop playing the game
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // Is only included if the game is not being compiled in the Unity Editor
        // Quits the game


        Application.Quit ();
#endif
    }
}
