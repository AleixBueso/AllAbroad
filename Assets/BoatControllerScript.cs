using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatControllerScript : MonoBehaviour {

    public float turnSpeed = 0.2f;
    public float turnAccel = 5f;

    public float Speed = 0f;            //Don't touch this
    public float MaxSpeed = 5f;        //This is the maximum speed that the object will achieve
    public float Acceleration = 5f;    //How fast will object reach a maximum speed
    public float Deceleration = 0.5f;    //How fast will object reach a speed of 0

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A))
            gameObject.transform.Rotate( - Vector3.up * turnSpeed);

        if (Input.GetKey(KeyCode.D))
            gameObject.transform.Rotate (Vector3.up * turnSpeed);

        if ((Input.GetKey(KeyCode.W)))
        {
            if (Speed < MaxSpeed)
                Speed = Speed + Acceleration * Time.deltaTime;
            else
                Speed = MaxSpeed;
        }

        else
        {
            if (Speed > 0)
                Speed = Speed - Deceleration * Time.deltaTime;
            else
                Speed = 0;
        }

        float movement = Speed * Time.deltaTime;
        gameObject.transform.Translate(0, 0, movement);


    }
}
