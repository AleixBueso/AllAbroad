using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 1;
    public float maxSpeed = 3f;
    public float acceleration = 5f;
    public float offset = 0.01f;
    control_script animationControler;
    BoxCollider boat;

    // Use this for initialization
    void Start () {
        boat = gameObject.transform.parent.gameObject.GetComponent<BoxCollider>();
        animationControler = gameObject.GetComponent<control_script>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if(gameObject.transform.localPosition.z < ((boat.size.z / 2) - offset))
                gameObject.transform.Translate(0, 0, speed);

            gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
            animationControler.Walk();
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            if (gameObject.transform.localPosition.z > - ((boat.size.z / 2) - offset))
                gameObject.transform.Translate(0, 0, speed);

            gameObject.transform.eulerAngles = new Vector3(0, 180, 0);
            animationControler.Walk();
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            if (gameObject.transform.localPosition.x < ((boat.size.x / 2) - offset))
                gameObject.transform.Translate(0, 0, speed);

            gameObject.transform.eulerAngles = new Vector3(0, 90, 0);
            animationControler.Walk();
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (gameObject.transform.localPosition.x > -((boat.size.x / 2) - offset))
                gameObject.transform.Translate(0, 0, speed);

            gameObject.transform.eulerAngles = new Vector3(0, 270, 0);
            animationControler.Walk();
        }

        else
            animationControler.OtherIdle();
    }
}
