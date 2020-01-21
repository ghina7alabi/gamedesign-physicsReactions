using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlate : MonoBehaviour {

    public float amount = 50f;
    Rigidbody rigidBody;

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal") * amount * Time.deltaTime;

        rigidBody = GetComponent<Rigidbody>();
        rigidBody.AddTorque(transform.up* horizontal);
    }

}
