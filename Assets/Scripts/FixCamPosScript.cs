using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixCamPosScript : MonoBehaviour {

    public float Ypos = 6f;
    public GameObject boat;
    private Vector3 original_pos;

	// Use this for initialization
	void Start () {
        original_pos = transform.position;

    }
	
	// Update is called once per frame
	void Update () {

        gameObject.transform.position = new Vector3(boat.transform.position.x + original_pos.x, Ypos + original_pos.y , boat.transform.position.z + original_pos.z);

	}
}
