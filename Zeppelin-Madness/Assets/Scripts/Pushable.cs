using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pushable : MonoBehaviour {

    public bool pushed = false;
    //assign the red top here
    public GameObject topBtn;
    private Vector3 initial;


    // Use this for initialization
    void Start () {
        if (topBtn!=null)
        {
            initial = topBtn.transform.position;
        }
    }
	
	// Update is called once per frame
	void Update () {
        

    }

    void push()
    {
        if (topBtn!=null)
        {
            Vector3 temp = new Vector3(0, 0.1f, 0);
            topBtn.transform.position -= temp;
        }
    }

    void unpush()
    {
        if (topBtn != null)
        {
            Vector3 temp = new Vector3(0, 0.1f, 0);
            topBtn.transform.position += temp;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

                if (pushed)
                {
                    pushed = false;
                    unpush();
                }
                else
                {
                    pushed = true;
                    push();
                }

            }
        }
            
    }

    void checkBinaryPuzzle()
    {
        GameObject top2 = GameObject.Find("Button_Top_2");
        GameObject top0 = GameObject.Find("Button_Top_0");

        GameObject top1 = GameObject.Find("Button_Top_1");
        GameObject top3 = GameObject.Find("Button_Top_3");

        if (topBtn.gameObject.name.Equals(top2.gameObject.name))
        {
            if (top2.transform.position != initial)
            {
                SceneManager.LoadScene("Level 5");
            }
        }
        
    }
}
