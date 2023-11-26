using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LimpiarSceneController : MonoBehaviour
{

    public int trabajoRealizado = 0;// 0 - 100
    public GameObject BtnSalir;
    public GameObject TrabajoRealizadoTextObject;
    private TextMeshPro TrabajoRealizadoText;

    // Start is called before the first frame update
    void Start()
    {
        reset();
        TrabajoRealizadoText = TrabajoRealizadoTextObject.GetComponent<TextMeshPro>();
    }

    private void reset() {
        trabajoRealizado = 0;
        BtnSalir.SetActive(false);
    }

    public void addTrabajoRealizado(int trabajoRealizadoToAdd) {
        this.trabajoRealizado += trabajoRealizadoToAdd;
        TrabajoRealizadoText.text = this.trabajoRealizado.ToString()+"%";

        if(trabajoRealizado >= 100) {
            Debug.Log("Trabajo realizado");
            BtnSalir.SetActive(true);
            GameModePersistence.puedeSeguirSiguienteZona = true;
        }
    }
    
}
