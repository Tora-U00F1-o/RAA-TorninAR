using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSceneController : MonoBehaviour
{

    public Transform dispositivo;
    private Animator dispositivoAnimator;
    // Start is called before the first frame update
    void Start()
    {
        dispositivoAnimator = dispositivo.GetComponent<Animator>();
    }


    public void showMap() {
        dispositivoAnimator.SetBool("MapaOn", true);
    }

    public void hideMap() {
        dispositivoAnimator.SetBool("MapaOn", false);
    }
}
