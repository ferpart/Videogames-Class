using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyableObject : MonoBehaviour {

    public bool destroyable = false;

    private int currentHealth = 1;

    public void Damage(int damageAmount)
    {
        if (destroyable)
        {
            currentHealth -= damageAmount;
            if (currentHealth <= 0)
            {
                Destroy(gameObject);

            }
        }
    }
}
