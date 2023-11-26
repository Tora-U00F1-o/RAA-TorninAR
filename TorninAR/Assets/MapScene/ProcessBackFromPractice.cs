using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProcessBackFromPractice : MonoBehaviour
{
    public string MainMenuScene;
    public string GameScene;

    private void OnMouseDown()
    {
        SceneManager.LoadScene(
            GameModePersistence.practiceMode ? MainMenuScene : GameScene 
        );

    }
}
