using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour {

    //used 80
    public int speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (speed == null)
        {
            speed = 90;
        }
        transform.Rotate(new Vector3(Time.deltaTime*speed,0,0));
	}
}
