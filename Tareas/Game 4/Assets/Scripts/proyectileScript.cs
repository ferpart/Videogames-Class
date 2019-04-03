using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proyectileScript : MonoBehaviour {

    public int proyectileDamage = 5;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            CompleteProject.PlayerMovement health = other.GetComponent<CompleteProject.PlayerMovement>();
            
            if (health != null)
            {
                health.Damage(proyectileDamage);
            }


        }
        Destroy(gameObject, 1f);
    }
}
