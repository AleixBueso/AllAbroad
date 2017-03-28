using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixCamPosScript : MonoBehaviour {

    public float Ypos = 6f;
    private GameObject boat;

	// Use this for initialization
	void Start () {
        boat = GameObject.Find("BoatController");
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.position.Set(5, Ypos,9);
	}
}
