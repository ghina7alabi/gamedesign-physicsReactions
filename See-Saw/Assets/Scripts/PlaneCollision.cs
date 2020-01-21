using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneCollision : MonoBehaviour {

   


    void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
    }

}
