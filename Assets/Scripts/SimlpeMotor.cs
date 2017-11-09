using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimlpeMotor : MonoBehaviour {

	private Rigidbody BoatRB;

	public float MotorForce = 100f;

	// Use this for initialization
	void Start () {
		BoatRB = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W))
			BoatRB.AddForce (new Vector3 (0, 0, -MotorForce));
	}
}
