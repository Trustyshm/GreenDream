using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameController : MonoBehaviour
{
    public GameObject slideMaster;
    private bool plantsMaxed;

    public GameObject moneyController;


    public GameObject plantOne;
    public GameObject plantTwo;
    public GameObject plantThree;
    public GameObject plantFour;

    private bool oneBool;
    private bool twoBool;
    private bool threeBool;
    private bool fourBool;

    public GameObject allPlantsCheck;
    public GameObject thirtyGoldCheck;
    public GameObject activeCheck;

    private float allTimer;
    public float allTimerMax;

    public GameObject endScreen;

    private int goldAmount;

    private bool doOnce;

    public TextMeshProUGUI valueText;

    public AudioSource audioSource;
    public AudioClip audioClip;

    private bool doOne;
    private bool doTwo;
    private bool doThree;

    // Start is called before the first frame update
    void Start()
    {
        allPlantsCheck.SetActive(false);
        thirtyGoldCheck.SetActive(false);
        activeCheck.SetActive(false);
        allTimer = 0f;
        doOnce = false;
        doOne = false;
        doTwo = false;
        doThree = false;
    }

    // Update is called once per frame
    void Update()
    {
        plantsMaxed = slideMaster.GetComponent<SliderMaster>().allPlants;
        if (plantsMaxed == true && doOne == false)
        {
            allPlantsCheck.SetActive(true);
            audioSource.PlayOneShot(audioClip);
            doOne = true;
        }


        valueText.text = allTimer.ToString("000");

        oneBool = plantOne.GetComponentInChildren<PlantController>().growingWell;
        twoBool = plantTwo.GetComponentInChildren<PlantController>().growingWell;
        threeBool = plantThree.GetComponentInChildren<PlantController>().growingWell;
        fourBool = plantFour.GetComponentInChildren<PlantController>().growingWell;
        if (oneBool == true && twoBool == true && threeBool == true && fourBool == true)
        {
            allTimer += Time.deltaTime;
        }else
        {
            allTimer = allTimer;
        }

        if (oneBool == false || twoBool == false || threeBool == false || fourBool == false)
        {
            allTimer = allTimer;
        }

    

        goldAmount = moneyController.GetComponent<MoneyController>().cashAmount;
        if (goldAmount >= 30 && doTwo == false)
        {
            thirtyGoldCheck.SetActive(true);
            audioSource.PlayOneShot(audioClip);
            doTwo = true;

        }
        if (allTimer >= allTimerMax && doThree == false)
        {
            activeCheck.SetActive(true);
            audioSource.PlayOneShot(audioClip);
            doThree = true;


        }
        
        if (activeCheck.activeSelf == true && thirtyGoldCheck.activeSelf == true && allPlantsCheck.activeSelf == true)
        {
            if (doOnce == false)
            {
                StartCoroutine(EndGame());
                doOnce = true;
            }
            
        }
    }

    IEnumerator EndGame()
    {
        yield return new WaitForSeconds(2f);
        endScreen.SetActive(true);

    }
}
