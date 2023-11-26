using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
	public LimpiarSceneController limpiarSceneController;
	public int trabajoRealizado = 50;
	public Transform player;
    private bool isDead = false;
    public float rotationSpeed = 0.5f;
    


	private void OnMouseDown(){
        GetComponent<Animator>().SetBool("Morido", true);
        limpiarSceneController.addTrabajoRealizado( trabajoRealizado );
        isDead = true;
	}

    void Update() {
        if(isDead) return;
        SmoothLookAtPlayer();
    }
	

	void SmoothLookAtPlayer () {
        Vector3 playerPosition = new Vector3(player.position.x, transform.position.y, player.position.z);
        Quaternion targetRotation = Quaternion.LookRotation(playerPosition - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
    }
    
}
