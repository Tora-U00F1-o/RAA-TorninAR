using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class ProcessStartGame : MonoBehaviour
{
    public string scene;
    public bool practiceMode;
    public GameModePersistence gameModePersistence;

    private void OnMouseDown()
    {
        gameModePersistence.practiceMode = practiceMode;
        SceneManager.LoadScene(scene);
    }
}
