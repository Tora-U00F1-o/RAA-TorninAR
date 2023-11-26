using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : LookAtPlayer
{
	public LimpiarSceneController limpiarSceneController;
	public int trabajoRealizado = 50;
    private bool isDead = false;
    
	private void OnMouseDown(){
        if(isDead) return;
        GetComponent<Animator>().SetBool("Morido", true);
        limpiarSceneController.addTrabajoRealizado( trabajoRealizado );
        isDead = true;
	}

    void Update() {
        if (!isDead)
        {
            SmoothLookAtPlayer();
        }
    }
	

	
    
}
