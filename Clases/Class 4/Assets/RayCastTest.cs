using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		// Raycast - shooting a ray from a vector
		// used for picking
		// used in FPS

		// THIS IS SLOW FOR CALCULATIONS

		if (Input.GetMouseButtonUp (0)) {
			// Ray from the mouse 
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast (ray, out hit)) {
				print (hit.transform.name + " " + hit.point);
			}
		}
	}
}
