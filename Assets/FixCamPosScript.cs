using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixCamPosScript : MonoBehaviour {

    public float Ypos = 14f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.position.Set(transform.position.x, Ypos, transform.position.z);
	}
}
