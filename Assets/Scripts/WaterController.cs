using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterController : MonoBehaviour
{
    public GameObject waterParticles;
    public Transform particleSpawner;
    public Animator cooldownBar;

    public AudioSource audioSource;
    public AudioClip audioClip;

    private void OnTriggerStay2D(Collider2D other)
    {

        if (other.gameObject.tag == "plant" && Input.GetMouseButton(0))
        {

            other.gameObject.GetComponentInChildren<PlantController>().inWater = true;
            this.GetComponent<Animator>().Play("PourCan");
            Instantiate(waterParticles, particleSpawner.position, transform.rotation);
            cooldownBar.Play("coolDown");
            audioSource.Play();


        }

    }


}
