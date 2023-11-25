using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

///--------------------------------
///   Author: Victor Alvarez, Ph.D.
///   University of Oviedo, Spain
///--------------------------------

public class Gu : MonoBehaviour
{
    public GuiController guiController;

    public void OnMouseDown(int menu)
    {
       guiController.showMenu(menu);

    }
}
