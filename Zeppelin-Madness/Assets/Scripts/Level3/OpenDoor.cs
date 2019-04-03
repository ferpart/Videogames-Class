using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class OpenDoor : MonoBehaviour {

    private void OnTriggerStay(Collider col)
    {
        if (col.tag == this.tag)
        {
            Destroy(col.gameObject);
            print("Door Opened");
            //SceneManager.LoadScene("Level 1", LoadSceneMode.Single);
            GameObject ywall = GameObject.Find("YellowWall");
            GameObject bwall = GameObject.Find("BlueWall");
            GameObject pwall = GameObject.Find("PurpleWall");

            if (col.tag == "blueKey")
            {
                Destroy(bwall.gameObject);
            }
            if (col.tag == "yellowKey")
            {
                Destroy(ywall.gameObject);
            }
            if (col.tag == "purpleKey")
            {
                Destroy(pwall.gameObject);
            }
            
            //Destroy(this);
        }
    }

}
