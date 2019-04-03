using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickable : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// mouse events
	// ALL use raycast

	void OnMouseEnter(){
		print ("mouse entering!");
	}

	void OnMouseOver(){
		print ("mouse over");
	}

	void OnMouseExit(){

		print ("no longer casting to the collider");
	}

	void OnMouseUp(){
		print ("mouse up");
	}
}
