using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pauser : MonoBehaviour
{
    private GameObject thisThingy;
    // Start is called before the first frame update
    void OnEnable()
    {
        Time.timeScale = 0.0f;
    }

    private void Start()
    {
        thisThingy = GameObject.FindGameObjectWithTag("endScreen");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(thisThingy.name);
    }

    void Unpause()
    {
        thisThingy = GameObject.FindGameObjectWithTag("endScreen");
        Time.timeScale = 1.0f;
        thisThingy.SetActive(false);
    }
}
