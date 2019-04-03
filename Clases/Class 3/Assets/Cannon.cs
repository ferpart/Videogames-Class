using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour {

    public float speed;
    public GameObject original;
	// Use this for initialization
	void Start () {
        /*
         * way to retrieve a reference
         * can return null
         */
        //original = GameObject.Find("Capsule");
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis("Horizontal");
        transform.Translate(speed * h * Time.deltaTime, 0, 0, Space.World);

        /*
         * Instancing
         * we cannot create a new gameobject from scratch
         * we have to clone
         */

        if (Input.GetKeyDown(KeyCode.Space)){

            GameObject clone = Instantiate(original,
            //GameObject clone = Instantiate(original, 
                                          transform.position, 
                                          transform.rotation) as GameObject;
            Rigidbody rb2 = clone.GetComponent<Rigidbody>();
            //Destroy(rb2);
        }

	}
}
