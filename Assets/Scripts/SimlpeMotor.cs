using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimlpeMotor : MonoBehaviour {

	private Rigidbody BoatRB;

	public float MotorForce = 100f;
    public float MotorTorque = 1f;

	// Use this for initialization
	void Start () {
		BoatRB = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
            BoatRB.AddForce(transform.forward * MotorForce);

        if (Input.GetKey(KeyCode.S))
            BoatRB.AddForce( - transform.forward * MotorForce);

        if (Input.GetKey(KeyCode.A))
            BoatRB.AddTorque(-transform.up * MotorTorque);

        if (Input.GetKey(KeyCode.D))
            BoatRB.AddTorque(transform.up * MotorTorque);
    }
}
