using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emisor : MonoBehaviour
{

    public GameObject[] enemies;
    public Vector3 spawnValues;
    public float spawnWait;
    public int startWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public bool stop;

    private int randEnemy;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(spawner());
    }

    // Update is called once per frame
    void Update()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
    }

    IEnumerator spawner()
    {
        yield return new WaitForSeconds(startWait);

        while (!stop)
        {
            //picking between zero and one number
            randEnemy = Random.Range(0, 2);
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 1, Random.Range(-spawnValues.z, spawnValues.z));
            Instantiate(enemies[0], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
            yield return new WaitForSeconds(spawnWait);
        }
    }

}
