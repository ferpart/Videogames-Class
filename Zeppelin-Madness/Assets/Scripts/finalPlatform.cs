using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalPlatform : MonoBehaviour {
   
    public int height = 10;//max height of Box's movement
    public float yCenter = 0f;
    
    //private bool move =false;
    

    void Start () {
        
    }

    // Update is called once per frame
    void Update () {
        //print(move);
        if (GameObject.Find("holdPlatform")!=null)
        {
           
        }
        else
        {
            transform.position = new Vector3(transform.position.x,
                                            yCenter + Mathf.PingPong(Time.time * 2, height) - height / 2f,
                                            transform.position.z);
        }
    }

    
}

