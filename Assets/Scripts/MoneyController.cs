using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoneyController : MonoBehaviour
{

    public Sprite hovering;
    public Sprite notHovering;
    public TextMeshProUGUI cash;
    public int cashValue;
    public int cashAmount;
    public GameObject cashParticles;

    public bool thirtyGold;

    public AudioSource audioSource;
    public AudioClip audioClip;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<SpriteRenderer>().sprite = notHovering;
        cashAmount = 0000;
        cash.text = cashAmount.ToString();
        
    }

    private void Update()
    {

        if (cashAmount < 0)
        {
            cashAmount = 0;
        }

        if (cashAmount >= 30)
        {
            thirtyGold = true;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {

        if (other.gameObject.tag == "cash")
        {

            this.GetComponent<SpriteRenderer>().sprite = hovering;


            if (Input.GetMouseButton(0))
            {

                Instantiate(cashParticles, other.gameObject.transform.position, other.gameObject.transform.rotation);
                Destroy(other.gameObject);
                cashAmount += cashValue;
                audioSource.PlayOneShot(audioClip);
                cash.text = cashAmount.ToString();
                
                this.gameObject.SetActive(false);
            }







        }

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "cash")
        {
            this.GetComponent<SpriteRenderer>().sprite = notHovering;
        }
    }
}
