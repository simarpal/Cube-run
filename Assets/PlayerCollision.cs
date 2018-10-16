using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public playerMoves  movement;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter( Collision collision){
		if(collision.collider.tag == "Obstacle"){
			movement.enabled = false;
		}
	}
}
