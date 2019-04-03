using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public bool isDamaging;
    public float damage;
    private Transform target;
    public float speed = 70f;
    public void Seek(Transform _target)
    {
        target = _target;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if (dir.magnitude <= distanceThisFrame)
        {
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
        transform.LookAt(target);
    }

    private void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player")
        {
            col.SendMessage((isDamaging) ? "TakeDamage" : "HealDamage", damage);
            Destroy(gameObject);
        }
    }
}
