using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

//https://gamedevbeginner.com/coroutines-in-unity-when-and-how-to-use-them/


public class SceneLoader : MonoBehaviour
{   

    public void LoadNextScene()
    { 
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;  
        SceneManager.LoadScene(currentSceneIndex + 1); 
    }
    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);   
    }
    public void QuitGame()
    {
        Application.Quit();
    } 
}
