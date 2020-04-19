using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseRightController : MonoBehaviour
{
    public float speed;

    public Transform[] endPoints;
    private int randomEnd;
    private GameObject[] endObjects;

    // Start is called before the first frame update
    void Start()
    {

        randomEnd = Random.Range(0, endPoints.Length);
        endObjects = GameObject.FindGameObjectsWithTag("spawnerR");
        endPoints = new Transform[endObjects.Length];
        for (int i = 0; i < endObjects.Length; i++)
        {
            endPoints[i] = endObjects[i].transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, endPoints[randomEnd].position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, endPoints[randomEnd].position) < 0.2f)
        {
            Destroy(gameObject);
        }
    }
}
