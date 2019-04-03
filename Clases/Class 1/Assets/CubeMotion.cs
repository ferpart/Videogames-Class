using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMotion : MonoBehaviour {
    // lifecycle
    // all monobehabiors have a lifecycle

    void Initialize(){

        //Same as start but runs before
        //runs even on disabled objacts
        print("Initializing");
    }

	// Use this for initialization
    // - run once the object is created
	void Start (){
        print("Hello World!");
	}
	
	// Update is called once per frame
    // -Game loop
    // -Fps framerate per second
    // -Realtime aplication -fps 30
    // -we'll try to hit at least 60fps
    //happens as many times as posible on a second
	void Update (){
        //print("updating");

        //input should go there
        //depend on the input class
        if (Input.GetKeyDown(KeyCode.W)){
            print("key down");
        };
        if (Input.GetKey(KeyCode.W))
        {
            print("key");
        };
        if (Input.GetKeyUp(KeyCode.W))
        {
            print("key up");
        };
        if (Input.GetMouseButton(0))
        {
            print("thumb button pressed");
        };
    }
    //you can configure a specific framerate
    /*void FixedUpdate(){
       
    }

    //happens after update each frame
    void LateUpdate(){
        
    }*/
}
