using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootCannon : MonoBehaviour {

    public GameObject CannonBall;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Q))
           CannonBall.GetComponent<Rigidbody>().AddForce(new Vector3(-20, 40, 0));
    }
}
