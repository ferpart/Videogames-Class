using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPack : MonoBehaviour {

    public bool isDamaging;
    public float damage;

    private void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player")
        {
            col.SendMessage((isDamaging) ? "TakeDamage" : "HealDamage", Time.deltaTime * damage);
        }
        Destroy(this.gameObject);
    }
}
