using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitOnClick : MonoBehaviour {

    public void Quit()
    {
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
