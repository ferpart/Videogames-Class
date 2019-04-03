using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour {

    

	public Waypoint[] path;
	public float threshold;
    public float speed;
    public int max_random;

    private int currentHealth = 1;
    private int number;

    Animator anim;


	// Use this for initialization
	void Start () {
        number = 0;
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

		transform.LookAt (path[number].transform);
		transform.Translate (transform.forward * Time.deltaTime * speed, Space.World);

		float distance = Vector3.Distance (transform.position, path[number].transform.position);

		if (distance < threshold) {
            number = Random.Range(0, max_random);
		}
	}

    public void Damage(int damageAmount)
    {
        currentHealth -= damageAmount;
        if (currentHealth <= 0)
        {
            Animating();
            
            
        }
    }

    void Animating()
    {
        anim.SetTrigger("dead");

        Destroy(gameObject, 2f);
    }
}
