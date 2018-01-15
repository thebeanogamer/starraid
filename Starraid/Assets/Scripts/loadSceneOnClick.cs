using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadSceneOnClick : MonoBehaviour
{
    public void LoadScene(string SceneToLoad)
    {
        // Tells the scene manager to load whatever scene it has been passed as a variable
        SceneManager.LoadSceneAsync(SceneToLoad);
    }
}
