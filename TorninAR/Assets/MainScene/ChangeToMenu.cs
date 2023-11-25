using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeToMenu : MonoBehaviour
{
    public GameObject ActualMenu;
    public GameObject NextMenu;

    private void OnMouseDown()
    {
        ActualMenu.SetActive(false);
        NextMenu.SetActive(true);
    }
}
