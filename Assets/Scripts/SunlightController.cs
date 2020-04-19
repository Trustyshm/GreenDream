using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunlightController : MonoBehaviour
{
    private float day;
    public float dayMax;

    public GameObject colliderOne;
    public GameObject colliderTwo;
    public GameObject colliderThree;
    public GameObject colliderFour;
    public GameObject colliderFive;
    public GameObject colliderSix;
    public GameObject colliderSeven;
    public GameObject colliderEight;
    public GameObject colliderNine;
    public GameObject colliderTen;
    public Quaternion temp;

    public Transform sunSpawn;
    public GameObject sun;

    public float speedSun;

    public float rotator;

    private bool sunActive;

    // Start is called before the first frame update
    void Start()
    {
        day = dayMax;
        colliderOne.SetActive(false);
        colliderTwo.SetActive(false);
        colliderThree.SetActive(false);
        colliderFour.SetActive(false);
        colliderFive.SetActive(false);
        colliderSix.SetActive(false);
        colliderSeven.SetActive(false);
        colliderEight.SetActive(false);
        colliderNine.SetActive(false);
        colliderTen.SetActive(false);

        Instantiate(sun, sunSpawn.position,sunSpawn.rotation);
        sunActive = true;



    }

    // Update is called once per frame
    void Update()
    {
        if (day >100 || day < 0)
        {
            colliderOne.SetActive(false);
            colliderTwo.SetActive(false);
            colliderThree.SetActive(false);
            colliderFour.SetActive(false);
            colliderFive.SetActive(false);
            colliderSix.SetActive(false);
            colliderSeven.SetActive(false);
            colliderEight.SetActive(false);
            colliderNine.SetActive(false);
            colliderTen.SetActive(false);
            temp = this.transform.rotation;
            temp.z = 90;
            //this.transform.Rotate(0, 0, 1, Space.Self);
            transform.rotation = Quaternion.Euler(0f, 0f, 270f);
            if (sunActive == false)
            {
                Instantiate(sun, sunSpawn.position, sunSpawn.rotation);
                sunActive = true;
            }
            
        }
        day -= Time.deltaTime;
        if (day <= 100 && day > 90)
        {
            colliderOne.SetActive(true);
            colliderTwo.SetActive(false);
            colliderThree.SetActive(false);
            colliderFour.SetActive(false);
            colliderFive.SetActive(false);
            colliderSix.SetActive(false);
            colliderSeven.SetActive(false);
            colliderEight.SetActive(false);
            colliderNine.SetActive(false);
            colliderTen.SetActive(false);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, 0f, 295f), speedSun * Time.deltaTime);
        }

        if (day <= 90 && day > 80)
        {
            colliderOne.SetActive(false);
            colliderTwo.SetActive(true);
            colliderThree.SetActive(false);
            colliderFour.SetActive(false);
            colliderFive.SetActive(false);
            colliderSix.SetActive(false);
            colliderSeven.SetActive(false);
            colliderEight.SetActive(false);
            colliderNine.SetActive(false);
            colliderTen.SetActive(false);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, 0f, 310f), speedSun * Time.deltaTime);
            
        }

        if (day <= 80 && day > 70)
        {
            colliderOne.SetActive(false);
            colliderTwo.SetActive(false);
            colliderThree.SetActive(true);
            colliderFour.SetActive(false);
            colliderFive.SetActive(false);
            colliderSix.SetActive(false);
            colliderSeven.SetActive(false);
            colliderEight.SetActive(false);
            colliderNine.SetActive(false);
            colliderTen.SetActive(false);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, 0f, 330f), speedSun * Time.deltaTime);
            
        }

        if (day <= 70 && day > 60)
        {
            colliderOne.SetActive(false);
            colliderTwo.SetActive(false);
            colliderThree.SetActive(false);
            colliderFour.SetActive(true);
            colliderFive.SetActive(false);
            colliderSix.SetActive(false);
            colliderSeven.SetActive(false);
            colliderEight.SetActive(false);
            colliderNine.SetActive(false);
            colliderTen.SetActive(false);

            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, 0f, 350f), speedSun * Time.deltaTime);
        }

        if (day <= 60 && day > 50)
        {
            colliderOne.SetActive(false);
            colliderTwo.SetActive(false);
            colliderThree.SetActive(false);
            colliderFour.SetActive(false);
            colliderFive.SetActive(true);
            colliderSix.SetActive(false);
            colliderSeven.SetActive(false);
            colliderEight.SetActive(false);
            colliderNine.SetActive(false);
            colliderTen.SetActive(false);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, 0f, 10f), speedSun * Time.deltaTime);
        }

        if (day <= 50 && day > 40)
        {
            colliderOne.SetActive(false);
            colliderTwo.SetActive(false);
            colliderThree.SetActive(false);
            colliderFour.SetActive(false);
            colliderFive.SetActive(false);
            colliderSix.SetActive(true);
            colliderSeven.SetActive(false);
            colliderEight.SetActive(false);
            colliderNine.SetActive(false);
            colliderTen.SetActive(false);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, 0f, 30f), speedSun * Time.deltaTime);
        }

        if (day <= 40 && day > 30)
        {
            colliderOne.SetActive(false);
            colliderTwo.SetActive(false);
            colliderThree.SetActive(false);
            colliderFour.SetActive(false);
            colliderFive.SetActive(false);
            colliderSix.SetActive(false);
            colliderSeven.SetActive(true);
            colliderEight.SetActive(false);
            colliderNine.SetActive(false);
            colliderTen.SetActive(false);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, 0f, 50f), speedSun * Time.deltaTime);
        }

        if (day <= 30 && day > 20)
        {
            colliderOne.SetActive(false);
            colliderTwo.SetActive(false);
            colliderThree.SetActive(false);
            colliderFour.SetActive(false);
            colliderFive.SetActive(false);
            colliderSix.SetActive(false);
            colliderSeven.SetActive(false);
            colliderEight.SetActive(true);
            colliderNine.SetActive(false);
            colliderTen.SetActive(false);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, 0f, 70f), speedSun * Time.deltaTime);
        }

        if (day <= 20 && day > 10)
        {
            colliderOne.SetActive(false);
            colliderTwo.SetActive(false);
            colliderThree.SetActive(false);
            colliderFour.SetActive(false);
            colliderFive.SetActive(false);
            colliderSix.SetActive(false);
            colliderSeven.SetActive(false);
            colliderEight.SetActive(false);
            colliderNine.SetActive(true);
            colliderTen.SetActive(false);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, 0f, 90f), speedSun * Time.deltaTime);
        }

        if (day <= 10 && day > 0)
        {
            colliderOne.SetActive(false);
            colliderTwo.SetActive(false);
            colliderThree.SetActive(false);
            colliderFour.SetActive(false);
            colliderFive.SetActive(false);
            colliderSix.SetActive(false);
            colliderSeven.SetActive(false);
            colliderEight.SetActive(false);
            colliderNine.SetActive(false);
            colliderTen.SetActive(true);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, 0f, 95f), speedSun * Time.deltaTime);
        }

        if (day <= 0)
        {
            day = dayMax;
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, 0f, 95f), speedSun * Time.deltaTime);
            sunActive = false;
        }
    }
}
