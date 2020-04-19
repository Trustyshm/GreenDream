using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunMovement : MonoBehaviour
{

    public float speedSun;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector2.right * speedSun * Time.deltaTime);
        StartCoroutine(KillSun());
    }

    IEnumerator KillSun()
    {
        yield return new WaitForSeconds(200f);
    }
}
