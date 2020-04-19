using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class SliderMaster : MonoBehaviour
{
    public GameObject leftPush;
    public GameObject rightPush;
    public GameObject wateringCan;
    public GameObject refresher;
    public GameObject coinPickup;

    public Image leftIcon;
    public Image leftBorder;
    public Image rightIcon;
    public Image rightBorder;
    public Image waterIcon;
    public Image waterBorder;
    public Image refreshIcon;
    public Image refreshBorder;
    public Image moneyIcon;
    public Image moneyBorder;
    public Image potIcon;
    public Image potBorder;

    public float newAlpha = 0.5f;

    public GameObject plantOne;
    public GameObject plantTwo;
    public GameObject plantThree;
    public GameObject plantFour;

    public GameObject moneyController;
    private int savedAmount;

    public float maxPlantCooldown;
    private float plantCooldown;

    private bool getPlant;

    public bool allPlants;

    public AudioSource audioSourceOne;
    public AudioClip audioClipOne;



    // Start is called before the first frame update
    void Start()
    {
        leftPush.SetActive(false); 
        Color temp = leftIcon.color;
        temp.a = 0.5f;
        leftIcon.color = temp;
        leftBorder.gameObject.SetActive(false);
       
        rightPush.SetActive(false);
        Color temp1 = rightIcon.color;
        temp1.a = 0.5f;
        rightIcon.color = temp1;
        rightBorder.gameObject.SetActive(false);

        wateringCan.SetActive(false);
        Color temp2 = waterIcon.color;
        temp2.a = 0.5f;
        waterIcon.color = temp2;
        waterBorder.gameObject.SetActive(false);

        refresher.SetActive(false);
        Color temp3 = refreshIcon.color;
        temp3.a = 0.5f;
        refreshIcon.color = temp3;
        refreshBorder.gameObject.SetActive(false);

        coinPickup.SetActive(false);
        Color temp4 = moneyIcon.color;
        temp4.a = 0.5f;
        moneyIcon.color = temp4;
        moneyBorder.gameObject.SetActive(false);

        plantOne.SetActive(true);
        Color temp5 = potIcon.color;
        temp4.a = 0.5f;
        potIcon.color = temp4;
        potBorder.gameObject.SetActive(false);

        plantCooldown = maxPlantCooldown;
        getPlant = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            leftPush.SetActive(true);
            Color temp = leftIcon.color;
            temp.a = 1f;
            leftIcon.color = temp;
            leftBorder.gameObject.SetActive(true);

            rightPush.SetActive(false);
            Color temp1 = rightIcon.color;
            temp1.a = 0.5f;
            rightIcon.color = temp1;
            rightBorder.gameObject.SetActive(false);

            wateringCan.SetActive(false);
            Color temp2 = waterIcon.color;
            temp2.a = 0.5f;
            waterIcon.color = temp2;
            waterBorder.gameObject.SetActive(false);

            refresher.SetActive(false);
            Color temp3 = refreshIcon.color;
            temp3.a = 0.5f;
            refreshIcon.color = temp3;
            refreshBorder.gameObject.SetActive(false);

            coinPickup.SetActive(false);
            Color temp4 = moneyIcon.color;
            temp4.a = 0.5f;
            moneyIcon.color = temp4;
            moneyBorder.gameObject.SetActive(false);


        }

        if (Input.GetKeyDown("2"))
        {
            leftPush.SetActive(false);
            Color temp = leftIcon.color;
            temp.a = 0.5f;
            leftIcon.color = temp;
            leftBorder.gameObject.SetActive(false);

            rightPush.SetActive(true);
            Color temp1 = rightIcon.color;
            temp1.a = 1f;
            rightIcon.color = temp1;
            rightBorder.gameObject.SetActive(true);

            wateringCan.SetActive(false);
            Color temp2 = waterIcon.color;
            temp2.a = 0.5f;
            waterIcon.color = temp2;
            waterBorder.gameObject.SetActive(false);

            refresher.SetActive(false);
            Color temp3 = refreshIcon.color;
            temp3.a = 0.5f;
            refreshIcon.color = temp3;
            refreshBorder.gameObject.SetActive(false);

            coinPickup.SetActive(false);
            Color temp4 = moneyIcon.color;
            temp4.a = 0.5f;
            moneyIcon.color = temp4;
            moneyBorder.gameObject.SetActive(false);


        }

        if (Input.GetKeyDown("3"))
        {
            leftPush.SetActive(false);
            Color temp = leftIcon.color;
            temp.a = 0.5f;
            leftIcon.color = temp;
            leftBorder.gameObject.SetActive(false);

            rightPush.SetActive(false);
            Color temp1 = rightIcon.color;
            temp1.a = 0.5f;
            rightIcon.color = temp1;
            rightBorder.gameObject.SetActive(false);

            wateringCan.SetActive(true);
            Color temp2 = waterIcon.color;
            temp2.a = 1f;
            waterIcon.color = temp2;
            waterBorder.gameObject.SetActive(true);

            coinPickup.SetActive(false);
            Color temp4 = moneyIcon.color;
            temp4.a = 0.5f;
            moneyIcon.color = temp4;
            moneyBorder.gameObject.SetActive(false);

            refresher.SetActive(false);
            Color temp3 = refreshIcon.color;
            temp3.a = 0.5f;
            refreshIcon.color = temp3;
            refreshBorder.gameObject.SetActive(false);



        }

        if (Input.GetKeyDown("5"))
        {
            leftPush.SetActive(false);
            Color temp = leftIcon.color;
            temp.a = 0.5f;
            leftIcon.color = temp;
            leftBorder.gameObject.SetActive(false);

            rightPush.SetActive(false);
            Color temp1 = rightIcon.color;
            temp1.a = 1f;
            rightIcon.color = temp1;
            rightBorder.gameObject.SetActive(false);

            wateringCan.SetActive(false);
            Color temp2 = waterIcon.color;
            temp2.a = 0.5f;
            waterIcon.color = temp2;
            waterBorder.gameObject.SetActive(false);

            refresher.SetActive(true);
            Color temp3 = refreshIcon.color;
            temp3.a = 1f;
            refreshIcon.color = temp3;
            refreshBorder.gameObject.SetActive(true);

            coinPickup.SetActive(false);
            Color temp4 = moneyIcon.color;
            temp4.a = 0.5f;
            moneyIcon.color = temp4;
            moneyBorder.gameObject.SetActive(false);



        }

        if (Input.GetKeyDown("4"))
        {
            leftPush.SetActive(false);
            Color temp = leftIcon.color;
            temp.a = 0.5f;
            leftIcon.color = temp;
            leftBorder.gameObject.SetActive(false);

            rightPush.SetActive(false);
            Color temp1 = rightIcon.color;
            temp1.a = 1f;
            rightIcon.color = temp1;
            rightBorder.gameObject.SetActive(false);

            wateringCan.SetActive(false);
            Color temp2 = waterIcon.color;
            temp2.a = 0.5f;
            waterIcon.color = temp2;
            waterBorder.gameObject.SetActive(false);

            refresher.SetActive(false);
            Color temp3 = refreshIcon.color;
            temp3.a = 0.5f;
            refreshIcon.color = temp3;
            refreshBorder.gameObject.SetActive(false);

            coinPickup.SetActive(true);
            Color temp4 = moneyIcon.color;
            temp4.a = 1f;
            moneyIcon.color = temp4;
            moneyBorder.gameObject.SetActive(true);



        }

        savedAmount = moneyController.GetComponent<MoneyController>().cashAmount;
        plantCooldown -= Time.deltaTime;

        if (plantFour.activeSelf == true)
        {

            Color temp9 = potIcon.color;
            temp9.a = 0.5f;
            potIcon.color = temp9;
            potBorder.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown("6"))
        {
            if (plantFour.activeSelf == true)
            {

                Color temp9 = potIcon.color;
                temp9.a = 0.5f;
                potIcon.color = temp9;
                potBorder.gameObject.SetActive(false);
            }
            if (plantCooldown <= 0 && plantTwo.activeSelf == true && plantThree.activeSelf == false && plantFour.activeSelf == false)
            {
                
                savedAmount = moneyController.GetComponent<MoneyController>().cashAmount;
                if (savedAmount >= 4)
                {
                    
                    plantThree.SetActive(true);
                    audioSourceOne.PlayOneShot(audioClipOne);
                    moneyController.GetComponent<MoneyController>().cashAmount -= 4;
                    moneyController.GetComponent<MoneyController>().cash.text = moneyController.GetComponent<MoneyController>().cashAmount.ToString();
                    plantCooldown = maxPlantCooldown;

                }


            }

            if (plantCooldown <= 0 && plantThree.activeSelf == true && plantFour.activeSelf == false)
            {
                savedAmount = moneyController.GetComponent<MoneyController>().cashAmount;
                if (savedAmount >= 4)
                {
                    plantFour.SetActive(true);
                    audioSourceOne.PlayOneShot(audioClipOne);
                    moneyController.GetComponent<MoneyController>().cashAmount -= 4;
                    moneyController.GetComponent<MoneyController>().cash.text = moneyController.GetComponent<MoneyController>().cashAmount.ToString();
                    plantCooldown = maxPlantCooldown;
                    allPlants = true;

                }


            }
        }

        if (savedAmount < 4)
        {
            Color temp7 = potIcon.color;
            temp7.a = 0.5f;
            potIcon.color = temp7;
            potBorder.gameObject.SetActive(false);
        }
        if (savedAmount >= 4) 
        {
            Color temp7 = potIcon.color;
            temp7.a = 1f;
            potIcon.color = temp7;
            potBorder.gameObject.SetActive(true);

            if (Input.GetKeyDown("6"))
            {

                leftPush.SetActive(false);
                Color temp = leftIcon.color;
                temp.a = 0.5f;
                leftIcon.color = temp;
                leftBorder.gameObject.SetActive(false);

                rightPush.SetActive(false);
                Color temp1 = rightIcon.color;
                temp1.a = 1f;
                rightIcon.color = temp1;
                rightBorder.gameObject.SetActive(false);

                wateringCan.SetActive(false);
                Color temp2 = waterIcon.color;
                temp2.a = 0.5f;
                waterIcon.color = temp2;
                waterBorder.gameObject.SetActive(false);

                refresher.SetActive(false);
                Color temp3 = refreshIcon.color;
                temp3.a = 0.5f;
                refreshIcon.color = temp3;
                refreshBorder.gameObject.SetActive(false);

                coinPickup.SetActive(false);
                Color temp4 = moneyIcon.color;
                temp4.a = 1f;
                moneyIcon.color = temp4;
                moneyBorder.gameObject.SetActive(false);

                if (plantCooldown <= 0)
                {

                    savedAmount = moneyController.GetComponent<MoneyController>().cashAmount;

                    if (plantOne.activeSelf == true && plantTwo.activeSelf == false && savedAmount >= 4 && plantFour.activeSelf == false)
                    {

                        plantTwo.SetActive(true);
                        audioSourceOne.PlayOneShot(audioClipOne);
                        moneyController.GetComponent<MoneyController>().cashAmount -= 4;
                        moneyController.GetComponent<MoneyController>().cash.text = moneyController.GetComponent<MoneyController>().cashAmount.ToString();
                        plantCooldown = maxPlantCooldown;

                    }

         
                
                }
                




            }
        }
        
    }
    IEnumerator PlantWaitOne()
    {
        yield return new WaitForSeconds(0.2f);
        savedAmount = moneyController.GetComponent<MoneyController>().cashAmount;
        if (plantTwo.activeSelf == true && plantThree.activeSelf == false && savedAmount > 4 && getPlant == true)
        {
            plantThree.SetActive(true);
            moneyController.GetComponent<MoneyController>().cashAmount -= 4;
            moneyController.GetComponent<MoneyController>().cash.text = moneyController.GetComponent<MoneyController>().cashAmount.ToString();
            plantCooldown = maxPlantCooldown;

        }

    }


}
