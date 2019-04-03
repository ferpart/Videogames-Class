using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour {

    // Use this for initialization
    public float min;
    public float max;
    public float speed;

    void Start () {
        min = transform.position.y;
        max = transform.position.y + 3;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time * speed, max - min) + min, transform.position.z);
    }
}
