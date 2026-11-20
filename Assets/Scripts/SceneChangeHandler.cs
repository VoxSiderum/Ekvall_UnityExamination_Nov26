using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// This component can be used to access methods for changing the scene, and quitting the game
// It can be used together with UnityEventOnTrigger, or UI-button-events, to decide when a scene should be changed or the game should be closed
public class SceneChangeHandler : MonoBehaviour
{
    public int SceneNo;


    private void Start()
    {
        Debug.Log(SceneNo);
    }

    public void ChangeScene()
    {
        if (SceneNo == 0)
        {
            // Load the scene named "MainMenu"
            SceneManager.LoadSceneAsync("MainMenu", LoadSceneMode.Single);
        }
        
        if (SceneNo == 1)
        {
            SceneManager.LoadSceneAsync("TutorialScreen", LoadSceneMode.Single);
        }
        
        if (SceneNo == 2)
        {
            SceneManager.LoadSceneAsync("Level1", LoadSceneMode.Single);
        }
        
        if (SceneNo == 3)
        {
            SceneManager.LoadSceneAsync("Level2", LoadSceneMode.Single);
        }
        
        if (SceneNo == 4)
        {
            SceneManager.LoadSceneAsync("GameOverSpikes", LoadSceneMode.Single);
        }
        
        if (SceneNo == 5)
        {
            SceneManager.LoadSceneAsync("GameOverFall", LoadSceneMode.Single);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
