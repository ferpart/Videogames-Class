using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlatform : MonoBehaviour {

    public int height = 10;//max height of Box's movement
    public float yCenter = 0f;

	
	void Update () {
 
            transform.position = new Vector3(transform.position.x,
                                                yCenter + Mathf.PingPong(Time.time * 2, height) - height / 2f,
                                                transform.position.z);

    }


}
