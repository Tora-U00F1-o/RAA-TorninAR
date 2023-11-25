using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcceptCallController : MonoBehaviour
{
    public GameSceneController gameSceneController;
    private void OnMouseDown()
    {
        gameSceneController.acceptCall();
    }
}
