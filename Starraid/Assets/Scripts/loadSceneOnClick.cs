using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadSceneOnClick : MonoBehaviour
{
    public void LoadScene(string SceneToLoad)
    {
        SceneManager.LoadSceneAsync(SceneToLoad);
    }
}
