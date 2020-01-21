using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeForce : MonoBehaviour {

    public float thrust;
    Rigidbody rb;


	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.up * thrust);

    }
}
