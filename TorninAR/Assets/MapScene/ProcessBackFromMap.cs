using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProcessBackFromMap : MonoBehaviour
{
    
    public GameModePersistence gameModePersistence;

    public string MainMenuScene;
    public string GameScene;

    private void OnMouseDown()
    {
        Debug.Log(" --> "+gameModePersistence.practiceMode);
        SceneManager.LoadScene(
            gameModePersistence.practiceMode ? MainMenuScene : GameScene 
        );

    }
}
