using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimpiarSceneController : MonoBehaviour
{

    public int trabajoRealizado = 0;// 0 - 100

    // Start is called before the first frame update
    void Start()
    {
        reset();
    }

    private void reset() {
        trabajoRealizado = 0;
    }

    public void addTrabajoRealizado(int trabajoRealizado) {
        this.trabajoRealizado += trabajoRealizado;
        Debug.Log(this.trabajoRealizado);
    }
    
}
