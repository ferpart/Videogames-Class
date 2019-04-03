using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour {

    

	public Waypoint[] path;
	public float threshold;
    public float speed;
    public int max_random;

    private int currentHealth = 4;
    private int number;

    private AState current;
    private ASymbol r, o, d;
    private MonoBehaviour currentBehaviour;

    Animator anim;


	// Use this for initialization
	void Start () {
        number = 0;
        anim = GetComponent<Animator>();

        AState running = new AState("running", typeof(Running));
        AState hurt = new AState("hurt", typeof(Hurt));
        AState dead = new AState("dead", typeof(Dead));

        r = new ASymbol("run man");
        o = new ASymbol("ouch man");
        d = new ASymbol("dead man");

        running.AddTransition(o, hurt);
        running.AddTransition(d, dead);

        hurt.AddTransition(r, running);
        hurt.AddTransition(d, dead);

        current = running;

        currentBehaviour = gameObject.AddComponent(current.Behaviour) as MonoBehaviour;

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
        ApplySymbol(o);
        if (currentHealth <= 0)
        {
            Animating();
            
        }
        
    }

    void Animating()
    {
        anim.SetTrigger("dead");
        ApplySymbol(d);
        Destroy(gameObject, 2f);
    }

    private void ApplySymbol(ASymbol symbol)
    {

        AState previous = current;
        current = current.ApplySymbol(symbol);

        if (previous != current)
        {

            // change script
            Destroy(currentBehaviour);
            currentBehaviour = gameObject.AddComponent(current.Behaviour) as MonoBehaviour;
        }
    }
}
