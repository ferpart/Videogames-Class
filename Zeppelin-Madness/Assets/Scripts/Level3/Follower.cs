using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{

    private GameObject wayPoint;
    private Vector3 wayPointPos;
    private float speed = 3.0f;
    void Start()
    {
        wayPoint = GameObject.Find("Soldier_demo");
    }

    void Update()
    {
        if (wayPoint) { 
        //set position equal to that node.
        wayPointPos = new Vector3(wayPoint.transform.position.x, transform.position.y, wayPoint.transform.position.z);
        //then follow
        wayPointPos = new Vector3(wayPoint.transform.position.x, transform.position.y, wayPoint.transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, wayPointPos, speed * Time.deltaTime);
        }
    }
}