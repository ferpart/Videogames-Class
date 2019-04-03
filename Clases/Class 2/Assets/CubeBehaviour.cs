using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		// initialize
		// at the beginning
	}
	
	// Update is called once per frame
	void Update () {
		// every frame 
		// getkeyup ... etc
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");
		//print (h);


		// OOP - if you don't know I'm sending you back with Salinas
		// transform - attribute
		// - reference pointing at this gameobject's transform
		transform.Translate(h * speed * Time.deltaTime, 
							v * speed * Time.deltaTime, 
							0);
		// how much does it move in a second?
		// 180 fps - 180 * 0.05 
		// 30 fps - 30 * 0.05

		// Time.deltaTime
		// - the amount of time in seconds between the last frame and
		// the current one

	}

	void OnCollisionEnter(Collision c){
		print ("collision with : " + c.transform.name);
		//Destroy (c.gameObject);
		Destroy(this.gameObject);
	}

	void OnCollisionStay(Collision c){
		//print ("collision stay");
	}

	void OnCollisionExit(Collision c){
		Debug.Log ("collision exit");
	}
}
