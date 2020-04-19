using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunlightControl : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "plant")
            other.gameObject.GetComponentInChildren<PlantController>().inSun = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "plant")
            collision.gameObject.GetComponentInChildren<PlantController>().inSun = false;
    }
}
