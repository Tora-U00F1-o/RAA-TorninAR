using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Vuforia;
public class VirtualButtonHandler : MonoBehaviour
{
	public GameObject obj;
	public VirtualButtonBehaviour virtualButton;

	void Start()
	{
        virtualButton.RegisterOnButtonPressed(OnButtonPressed);
        virtualButton.RegisterOnButtonReleased(OnButtonReleased);
        Debug.Log("Button Registered");
	}
	public void OnButtonPressed(VirtualButtonBehaviour vb)
	{
        Debug.Log("Button Pressed");
	    obj.SetActive(false);
	}
	public void OnButtonReleased(VirtualButtonBehaviour vb)
	{
        Debug.Log("Button Released");
	    obj.SetActive(true);
	}
}
  