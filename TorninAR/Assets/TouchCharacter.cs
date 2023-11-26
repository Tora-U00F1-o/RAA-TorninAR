using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///--------------------------------
/// Author: Victor Alvarez, Ph.D.
/// University of Oviedo, Spain
///--------------------------------

	public class TouchCharacter : MonoBehaviour
{
	public string URL;
	private void OnMouseDown()
	{
		Application.OpenURL(URL);
	}

}
