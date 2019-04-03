using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootableObject : MonoBehaviour {

    public int currentHealth = 1;
    public Material objectEnabled;
    public string switchTag;
    

    public void Damage(int damageAmount)
    {
        currentHealth -= damageAmount;
        if (currentHealth <= 0)
        {
            GetComponent<MeshRenderer>().material = objectEnabled;
  
                destroyElement(switchTag);

        }
    }

    private void destroyElement (string tag)
    {
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag(tag);
        foreach (GameObject target in gameObjects)
        {
            GameObject.Destroy(target);
        }
    }

}
