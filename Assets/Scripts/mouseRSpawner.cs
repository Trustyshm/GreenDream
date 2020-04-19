using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseRSpawner : MonoBehaviour
{
    private float waitTime;
    public float startWaitTimeMax;
    public float startWaitTimeMin;

    public Transform[] spawnPoints;
    private int randomSpawn;

    public GameObject mouseRight;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = 15f;
        randomSpawn = Random.Range(0, spawnPoints.Length);
    }

    // Update is called once per frame
    void Update()
    {
        if (waitTime <= 0)
        {
            randomSpawn = Random.Range(0, spawnPoints.Length);
            Instantiate(mouseRight, spawnPoints[randomSpawn].position, spawnPoints[randomSpawn].transform.rotation);
            waitTime = Random.Range(startWaitTimeMin, startWaitTimeMax);

        }
        else
        {
            waitTime -= Time.deltaTime;
        }

    }
}
