using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    private Rigidbody rb;
    /*private static Projectile instance;
    public static Projectile Instance{
        get{
            return instance;
        }


    }

    private void Awake(){
        instance = this.gameObject;
    }*/

    public float speed;

	// Use this for initialization    
	void Start () {

        //retrieve a reference to a component
        rb = GetComponent<Rigidbody>();
        /* 
         * up, right and forward are on global space
         * these vectors are always unit vector
         */
        rb.AddForce(transform.up * speed, ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
