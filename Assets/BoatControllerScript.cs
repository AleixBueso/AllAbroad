using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatControllerScript : MonoBehaviour {

    float turnSpeed = 0.2f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A))
            gameObject.transform.Rotate( - Vector3.up * turnSpeed);

        if (Input.GetKey(KeyCode.D))
            gameObject.transform.Rotate (Vector3.up * turnSpeed);

        if (Input.GetKey(KeyCode.W))
        {
            //Vector3 newPos = transform.position.x
            //gameObject.transform.position = new Vector3(transform.position.x)
        }


    }
}
