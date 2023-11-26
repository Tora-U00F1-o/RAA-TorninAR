using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class ChangeScenePersistence : MonoBehaviour
{
    public string scene;
    public bool newPracticeMode;

    private void OnMouseDown()
    {
       GameModePersistence.practiceMode = newPracticeMode;
        SceneManager.LoadScene(scene);
    }
}
