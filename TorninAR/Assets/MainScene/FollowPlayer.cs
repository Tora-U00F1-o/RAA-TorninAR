using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FollowPlayer : MonoBehaviour {
	public Transform player;
	public void Start()
	{
		Debug.Log("Start");
	}
	private void OnMouseDown(){
        changePosition();
	}

	

	void changePosition () {
        transform.position = new Vector3((Random.insideUnitSphere.x *
            Random.Range(2f, 5f)), (Random.insideUnitSphere.z * Random.Range(0.8f, 1.8f)),
            (Random.insideUnitSphere.z * Random.Range(3f, 5f)));
        Vector3 playerPosition = new Vector3(player.position.x, transform.position.y, player.position.z);
        transform.LookAt(playerPosition);
	}
    
}
