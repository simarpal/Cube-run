using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMoves : MonoBehaviour {

	public Rigidbody rigidbody;
	public float forwardForce = 1000f;
	public float sideForce = 500f;

	// Use this for initialization
	void Start () {
		
	}	

	// Update is called once per frame
	void FixedUpdate () {
		rigidbody.AddForce(0, 0, forwardForce*Time.deltaTime);

		if(Input.GetKey("d")){
			rigidbody.AddForce(sideForce*Time.deltaTime, 0, 0);
		}
		if(Input.GetKey("a")){
			rigidbody.AddForce(-sideForce*Time.deltaTime, 0, 0);			
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
