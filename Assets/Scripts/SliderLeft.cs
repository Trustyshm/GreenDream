using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderLeft : MonoBehaviour
{

   
    private float slideCooldown;
    public float maxSlideCooldown;

    public Sprite hovering;
    public Sprite notHovering;

    public AudioSource audioSource;
    public AudioClip audioClip;

    // Start is called before the first frame update
    void Start()
    {
        slideCooldown = maxSlideCooldown;
        this.GetComponent<SpriteRenderer>().sprite = notHovering;
    }

    // Update is called once per frame
    void Update()
    {
        slideCooldown -= Time.deltaTime;


    }

    private void OnTriggerStay2D(Collider2D other)
    {

        if (other.gameObject.tag == "plant" && slideCooldown <= 0)
        {

            this.GetComponent<SpriteRenderer>().sprite = hovering;


            if (Input.GetMouseButton(0))
            {
                audioSource.PlayOneShot(audioClip);
                other.GetComponent<Rigidbody2D>().AddForce(-other.transform.right * 50.0f);

                this.gameObject.SetActive(false);
            }



           



        }

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "plant")
        {
            this.GetComponent<SpriteRenderer>().sprite = notHovering;
        }
    }
}
