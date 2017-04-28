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

    public ParticleSystem[] smokeEmitter;
    public ParticleSystem[] cannonEmitters;
    public GameObject LeftCannon;
    public GameObject RightCannon;
    public GameObject Engine;
    public Object CannonBall;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {

        for(uint i = 0; i < smokeEmitter.Length; i++)
            smokeEmitter[i].enableEmission = false;

        Engine.GetComponent<Animator>().SetBool("Working", false);

        LeftCannon.GetComponent<Animator>().SetBool("Shoot", false);
        RightCannon.GetComponent<Animator>().SetBool("Shoot", false);

        if (Input.GetKey(KeyCode.Q))
        {
            if (LeftCannon.GetComponent<CannonValuesScript>().is_charged)
            {
                LeftCannon.GetComponent<Animator>().SetBool("Shoot", true);
                cannonEmitters[1].Play();
                GameObject Clone = (GameObject)Instantiate(CannonBall, LeftCannon.transform.parent.transform.position, LeftCannon.transform.parent.transform.rotation);
                Clone.GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3(0, 8, -20));
                LeftCannon.GetComponent<CannonValuesScript>().is_charged = false;
            }
        }

        if (Input.GetKey(KeyCode.E))
        {
            if (RightCannon.GetComponent<CannonValuesScript>().is_charged)
            {
                RightCannon.GetComponent<Animator>().SetBool("Shoot", true);
                cannonEmitters[0].Play();
                GameObject Clone = (GameObject)Instantiate(CannonBall, RightCannon.transform.parent.transform.position, RightCannon.transform.parent.transform.rotation);
                Clone.GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3(0, 8, 20));
                RightCannon.GetComponent<CannonValuesScript>().is_charged = false;
            }
        }

        if(Input.GetKey(KeyCode.R))
        {
            RightCannon.GetComponent<CannonValuesScript>().is_charged = true;
            LeftCannon.GetComponent<CannonValuesScript>().is_charged = true;
        }

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

            for (uint i = 0; i < smokeEmitter.Length; i++)
                smokeEmitter[i].enableEmission = true;

            Engine.GetComponent<Animator>().SetBool("Working", true);

        }

        else
        {
            if (Speed > 0)
                Speed = Speed - Deceleration * Time.deltaTime;
            else
                Speed = 0;
        }

        float movement = Speed * Time.deltaTime;
        gameObject.transform.Translate(-movement, 0, 0);


    }
}
