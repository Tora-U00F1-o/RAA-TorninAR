using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuiController : MonoBehaviour
{

    public GameObject mainMenu;
    public GameObject practicaMenu;
    public GameObject aboutMenu;

    private GameObject[] menus;
    private int currentMenu;

    // Start is called before the first frame update
    void Start()
    {
        mainMenu.SetActive(true);
        practicaMenu.SetActive(false);
        aboutMenu.SetActive(false);
        menus = new GameObject[3];
        menus[0] = mainMenu;
        menus[1] = practicaMenu;
        menus[2] = aboutMenu;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showMenu(int menu)
    {
        menus[currentMenu].SetActive(false);
        currentMenu = menu;
        menus[currentMenu].SetActive(true);
    }
}
