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

    public VideoPlayer videoPlayer;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.loopPointReached += OnVideoEnded;
    }

    // Update is called once per frame
    void Update()
    {
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
    }
}

