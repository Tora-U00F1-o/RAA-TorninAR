using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

///--------------------------------
///   Author: Victor Alvarez, Ph.D.
///   University of Oviedo, Spain
///--------------------------------

public class ChangeScene : MonoBehaviour
{
    public string scene;

    private void OnMouseDown()
    {
       SceneManager.LoadScene(scene);

    }
}
