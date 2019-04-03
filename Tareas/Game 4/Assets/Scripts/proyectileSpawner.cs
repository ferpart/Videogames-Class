using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proyectileSpawner : MonoBehaviour {

    public GameObject proyectile;
    public float waitingTime = 5.0f;
    public int proyectileDamage = 5;

    private float timer = 0.0f;
    

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > waitingTime)
        {
            timer = 0f;

            GameObject clone = Instantiate(proyectile, new Vector3(Rand()[0],
                                                               transform.position.y,
                                                               Rand()[1]),
                                                               Quaternion.identity) as GameObject;

        }

    }

    private int[] Rand()
    {
        int randX = Mathf.Clamp(Random.Range(-9, 9), -9, 9);
        int randZ = Mathf.Clamp(Random.Range(-9, 9), -9, 9);
        int[] final = {randX, randZ};
        return final;
    }

}
