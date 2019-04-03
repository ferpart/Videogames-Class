using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelEndAlt : MonoBehaviour
{


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Main Hub");
        }
    }

}
