using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class GameSceneController : MonoBehaviour
{
    public GameObject StartScreen;
    public GameObject IncomingCallScreen;
    public GameObject VideoScreen;
    public GameObject BuscarZonaScreen;
    public GameObject ZonaEncontradaScreen;
    public GameObject FinJuegoScreen;

    public VideoPlayer videoPlayer;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.loopPointReached += OnVideoEnded;

        //Enseñamos la pantalla en función del estado del juego
        IncomingCallScreen.SetActive(false);
        VideoScreen.SetActive(false);

        if(GameModePersistence.zonaActual > 0) {
            loadScreen(BuscarZonaScreen);
        } else {
            loadScreen(StartScreen);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // if(BuscarZonaScreen.activeSelf ) {
        //     bool isInZona = false;
        //     if(isInZona) {
        //         loadScreen(ZonaEncontradaScreen);
        //     }


        // }
    }

    public void destinoAlcanzado() {
        if(GameModePersistence.zonaActual == 2){
            loadScreen(FinJuegoScreen);
            return;
        }
        if(GameModePersistence.llamadaRecibida){
            loadScreen(ZonaEncontradaScreen);
        } else {
            loadScreen(IncomingCallScreen);
        }
    }

    private void loadScreen(GameObject screen) {
        StartScreen.SetActive(false);
        IncomingCallScreen.SetActive(false);
        VideoScreen.SetActive(false);
        BuscarZonaScreen.SetActive(false);
        ZonaEncontradaScreen.SetActive(false);  
        FinJuegoScreen.SetActive(false);

        screen.SetActive(true);
    }

    public void acceptCall() {
        IncomingCallScreen.SetActive(false);
        VideoScreen.SetActive(true);
        videoPlayer.Play();
    }

    void OnVideoEnded(UnityEngine.Video.VideoPlayer vp)
    {
        videoPlayer.Pause();
        VideoScreen.SetActive(false);
        BuscarZonaScreen.SetActive(true);
        GameModePersistence.puedeSeguirSiguienteZona = false;
        GameModePersistence.zonaActual = 0;
        GameModePersistence.llamadaRecibida = true;
    }
}

