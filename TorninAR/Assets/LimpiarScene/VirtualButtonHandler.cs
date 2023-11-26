using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Vuforia;
public class VirtualButtonHandler : MonoBehaviour
{
	public LimpiarSceneController limpiarSceneController;
	public int trabajoRealizado = 25;
    public GameObject obj1, obj2;
    public VirtualButtonBehaviour vb1, vb2;

	void Start()
	{
        vb1.RegisterOnButtonPressed(OnButtonPressed);
        vb2.RegisterOnButtonPressed(OnButtonPressed);
	}
	public void OnButtonPressed(VirtualButtonBehaviour vb)
	{
        if (vb == vb1)
        {
            obj1.SetActive(false);
            limpiarSceneController.addTrabajoRealizado( trabajoRealizado );
        }
        else if (vb == vb2)
        {
            obj2.SetActive(false);
            limpiarSceneController.addTrabajoRealizado( trabajoRealizado );
        }
	}
}
  