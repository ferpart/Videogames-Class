using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounceObject : MonoBehaviour {

    public GameObject player;


 void OnCollisionEnter(Collision other)
     {
        if (player.tag== "Player")
        {
            other.rigidbody.AddForce(new Vector3(100, 0, 0));
        }
     }
}
