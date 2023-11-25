using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

///--------------------------------
///   Author: Victor Alvarez, Ph.D.
///   University of Oviedo, Spain
///--------------------------------

public class TouchCharacter : MonoBehaviour
{
    //public string URL;
    public Material mat1;
    public Material mat2;
    public Component c;
    private bool on;
    // public string scene;

    private void OnMouseDown()
    {
        GetComponent<Renderer>().material = on ? mat1 : mat2 ;
        on = !on;
        //Debug.Log("touché");
       //Application.OpenURL(URL);
       // SceneManager.LoadScene(scene);

    }
}
