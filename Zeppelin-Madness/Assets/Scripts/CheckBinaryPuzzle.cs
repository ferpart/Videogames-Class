using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CheckBinaryPuzzle : MonoBehaviour {

    private Vector3 initial0;
    private Vector3 initial1;
    private Vector3 initial2;
    private Vector3 initial3;

    GameObject top2;
    GameObject top0;
    GameObject top1;
    GameObject top3;

    // Use this for initialization
    void Start () {
        top2 = GameObject.Find("Button_Top_2");
        top0 = GameObject.Find("Button_Top_0");
        top1 = GameObject.Find("Button_Top_1");
        top3 = GameObject.Find("Button_Top_3");

        initial0 = top0.transform.position;
        initial1 = top1.transform.position;
        initial2 = top2.transform.position;
        initial3 = top3.transform.position;

    }

    // Update is called once per frame
    void Update () {
        if (top2.transform.position != initial2 && top0.transform.position != initial0) //&& top1.transform.position == initial1 && top3.transform.position == initial3)
        {
            SceneManager.LoadScene("Level 5");
        }

    }
}
