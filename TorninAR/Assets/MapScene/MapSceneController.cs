using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSceneController : MonoBehaviour
{

    public Transform dispositivo;
    private Animator dispositivoAnimator;

    public GameObject Zona0;
    public GameObject Zona1;
    public GameObject Zona2;




    // Start is called before the first frame update
    void Awake()
    {
        dispositivoAnimator = dispositivo.GetComponent<Animator>();
    }
    void Start(){
        if(!GameModePersistence.practiceMode){
            LoadMapContent();
        } 
    }


    public void ShowMap() {
        dispositivoAnimator.SetBool("MapaOn", true);
    }

    public void HideMap() {
        dispositivoAnimator.SetBool("MapaOn", false);
    }
    
    private void LoadMapContent() {
        switch (GameModePersistence.zonaObjetivo) {
            case 0:
                Zona0.SetActive(true);
                Zona1.SetActive(false);
                Zona2.SetActive(false);
                break;
            case 1:
                Zona0.SetActive(false);
                Zona1.SetActive(true);
                Zona2.SetActive(false);
                break;
            case 2:
                Zona0.SetActive(false);
                Zona1.SetActive(false);
                Zona2.SetActive(true);
                break;
        }
    }
}
