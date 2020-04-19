using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefreshController : MonoBehaviour
{
    public Sprite hovering;
    public Sprite notHovering;
    public GameObject moneyController;
    private int savedAmount;

    // Start is called before the first frame update
    void Start()
    {
        savedAmount = moneyController.GetComponent<MoneyController>().cashAmount;
    }



    private void OnTriggerStay2D(Collider2D other)
    {

        if (other.gameObject.tag == "plant")
        {

            this.GetComponent<SpriteRenderer>().sprite = hovering;
            savedAmount = moneyController.GetComponent<MoneyController>().cashAmount;

            if (Input.GetMouseButton(0) && other.gameObject.GetComponentInChildren<PlantController>().refreshable == true && savedAmount >= 1)
            {
                
                other.GetComponentInChildren<PlantController>().Refresh();
                this.gameObject.SetActive(false);
                moneyController.GetComponent<MoneyController>().cashAmount -= 1;
                moneyController.GetComponent<MoneyController>().cash.text = moneyController.GetComponent<MoneyController>().cashAmount.ToString();
            }

            if (Input.GetMouseButton(0) && other.gameObject.GetComponentInChildren<PlantController>().refreshable == true && savedAmount < 1)
            {

                Debug.Log("Not Enough Money");
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
