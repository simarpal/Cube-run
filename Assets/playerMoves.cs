using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMoves : MonoBehaviour {

	public Rigidbody rb;
	public float forwardForce;
	public float sideForce;

	// Use this for initialization
	void Start () {
		
	}	

	// Update is called once per frame
	void FixedUpdate () {
		rb.AddForce(0, 0, forwardForce*Time.deltaTime);

		if(Input.GetKey("d")){
			rb.AddForce(sideForce*Time.deltaTime, 0, 0);
		}
		if(Input.GetKey("a")){
			rb.AddForce(-sideForce*Time.deltaTime, 0, 0);			
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
