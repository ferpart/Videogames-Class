using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelChanger : MonoBehaviour {


    private string level;

	// Use this for initialization
	void Start () {
        string levelTrigger = gameObject.name;

        switch (levelTrigger)
        {
            case "Level 1 Trigger":
                level = "Level 1";
                break;
            case "Level 2 Trigger":
                level = "Level 2";
                break;
            case "Level 3 Trigger":
                level = "Level 3";
                break;
            case "Level 4 Trigger":
                level = "Level 4";
                break;
            case "Level 5 Trigger":
                level = "Level 5";
                break;
        }

	}

    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(level);
        }
    }

}
