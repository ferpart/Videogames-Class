using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon1 : MonoBehaviour {

    float speed = 25;
    float rotSpeed = 150;
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
        float v = Input.GetAxis("Vertical");
        transform.Translate(speed * v * Time.deltaTime, 0, 0);
        transform.Rotate(-rotSpeed * h * Time.deltaTime, 0, 0);
        /*
         * Instancing
         * we cannot create a new gameobject from scratch
         * we have to clone
         */

        if (Input.GetKeyDown(KeyCode.RightShift)){

            GameObject clone = Instantiate(original,
            //GameObject clone = Instantiate(original, 
                                          transform.position, 
                                          transform.rotation) as GameObject;
            Rigidbody rb2 = clone.GetComponent<Rigidbody>();
            //Destroy(rb2);
        }

	}
}
