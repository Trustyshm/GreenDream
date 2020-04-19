using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlantController : MonoBehaviour
{

    public bool growingWell;
    private float maskSize;
    public float timerMax = 10;
    public float shrinkTimer;
    public GameObject growthParticles;
    public Transform particleSpawner;
    public float maskShrinkSpeed = 0.02f;
    public GameObject plantSecondStage;
    public GameObject plantFirstStage;
    public GameObject leafParticles;
    private bool doOnce;

    public bool inSun;
    public bool inWater;
    public Image sunBar;
    public Image waterBar;
    public GameObject warningBar;
    public float sunDecay;
    public float waterDecay;
    public float sunTimerMax;
    public float waterTimerMax;
    private float sunTimer;
    private float waterTimer;
    public float sunGrowth;
    public float waterGrowth;

    private GameObject wateringCan;

    private float deathTimer;
    public float maxDeathTimer;

    public Animator sunAnimator;

    public GameObject deadIcon;

    public GameObject stage1;
    public GameObject stage2;
    public Animator stage1anim;
    public Animator stage2anim;


    public bool refreshable;
    public Collider2D sunLight;

    private bool fullyGrown;

    public float fullCounterMax;
    private float fullCounter;
    public int growStageAmount;
    private int growStage;

    public GameObject coinLeft;
    public GameObject coinRight;

    private float randomDirection;

    private bool otherDoOnce;

    public Transform coinSpawn;


    public AudioSource audioSource;
    public AudioClip audioClip;

    public AudioSource audioSourceB;
    public AudioClip audioClipB;

    public AudioSource audioSourceC;
    public AudioClip audioClipC;

    private bool dieOnce;



    private void OnTriggerStay2D(Collider2D other)
    {

        if (other.gameObject.tag == "sunlight")
            inSun = true;

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "sunlight")
            inSun = false;

    }

    // Start is called before the first frame update
    void Start()
    {
        growingWell = true;
        shrinkTimer = timerMax;
        maskSize = 1;
        doOnce = false;
        sunTimer = sunTimerMax;
        waterTimer = waterTimerMax;
        inSun = false;
        inWater = false;
        waterBar.fillAmount = Random.Range(0.3f, 0.8f);
        sunBar.fillAmount = Random.Range(0.3f, 0.8f);
        warningBar.SetActive(false);
        deathTimer -= maxDeathTimer;
        deadIcon.SetActive(false);
        plantSecondStage.SetActive(false);
        plantFirstStage.SetActive(true);
        refreshable = false;
        fullyGrown = false;
        fullCounter = fullCounterMax;
        growStage = 0;
        otherDoOnce = false;
        dieOnce = false;

    }

    // Update is called once per frame
    void Update()
    {
        
        if (shrinkTimer > 0 && plantFirstStage.activeSelf == true || plantSecondStage.activeSelf == true)
        {
            shrinkTimer -= Time.deltaTime;
        }

        if (shrinkTimer <= 0 && growingWell == true && maskSize >=0)
        {
            Instantiate(leafParticles, particleSpawner.position, transform.rotation);
            maskSize = this.gameObject.transform.localScale.y;
            maskSize -= maskShrinkSpeed;
            this.gameObject.transform.localScale = new Vector3(this.transform.localScale.x, maskSize, this.transform.localScale.z);
            shrinkTimer = timerMax;

        }

        if (maskSize <= 0 && doOnce == false)
        {
           
            plantSecondStage.SetActive(true);
            Instantiate(growthParticles, particleSpawner.position, transform.rotation);
            plantFirstStage.SetActive(false);
            doOnce = true;
        }

        if (plantSecondStage.activeSelf == true && growingWell == true)
        {
            fullCounter -= Time.deltaTime;
            if (fullCounter <= 0)
            {
                growStage += 1;
            }

        }

        if (growStage == growStageAmount && otherDoOnce == false)
        {
            //End Particles
            growingWell = false;
            randomDirection = Random.Range(0, 10);
            if (randomDirection > 5)
            {
                Instantiate(coinRight, coinSpawn.position, coinSpawn.rotation);
                audioSource.PlayOneShot(audioClip);
                sunBar.gameObject.SetActive(false);
                waterBar.gameObject.SetActive(false);
                warningBar.gameObject.SetActive(false);
                plantSecondStage.SetActive(false);
                refreshable = true;
                growingWell = false;
                otherDoOnce = true;
                sunTimer = 100000f;
                waterTimer = 100000f;
                deathTimer = 100000f;
            }
            if (randomDirection <= 5)
            {
                Instantiate(coinLeft, coinSpawn.position, coinSpawn.rotation);
                audioSource.PlayOneShot(audioClip);
                sunBar.gameObject.SetActive(false);
                waterBar.gameObject.SetActive(false);
                warningBar.gameObject.SetActive(false);
                plantSecondStage.SetActive(false);
                refreshable = true;
                growingWell = false;
                otherDoOnce = true;
                sunTimer = 100000f;
                waterTimer = 100000f;
                deathTimer = 100000f;
            }

        }

        if (inSun == false)
        {
            sunTimer -= Time.deltaTime;
            if (sunTimer <= 0)
            {
                sunBar.fillAmount -= sunDecay;
                sunTimer = sunTimerMax;
            }
            
        }

        if (inWater == false)
        {
            waterTimer -= Time.deltaTime;
            if (waterTimer <= 0)
            {
                waterBar.fillAmount -= waterDecay;
                waterTimer = waterTimerMax;
            }
        }

        if (sunBar.gameObject.activeSelf == false)
        {
            growingWell = false;
        }

        if (inSun == true)
        {
            sunTimer -= Time.deltaTime;
            if (sunTimer <= 0)
            {
                sunBar.fillAmount += sunGrowth;
                sunTimer = sunTimerMax;
            }
        }

        if (inWater == true)
        {
            waterBar.fillAmount += waterGrowth;
            StartCoroutine (WaterFill());
            

        }
        if (waterBar.fillAmount == 0f)
        {
   
            warningBar.SetActive(true);
            //deathTimer -= Time.deltaTime;
            growingWell = false;
            //animations?
        }

        if (sunBar.fillAmount >= 0.99f && deadIcon.activeSelf == false)
        {
            warningBar.SetActive(true);
            //deathTimer -= Time.deltaTime;
            sunAnimator.Play("SunFlash");
            growingWell = false;
        }

        if (sunBar.fillAmount < 0.99f && sunBar.fillAmount > 0f && waterBar.fillAmount != 0f)
        {
            warningBar.SetActive(false);
            deathTimer = maxDeathTimer;
            sunAnimator.Play("SunStatic");
            growingWell = true;
        }

        if (plantFirstStage.activeSelf == false && plantSecondStage.activeSelf == false)
        {
            growingWell = false;
            warningBar.SetActive(false);
        }

        if (sunBar.fillAmount <= 0)
        {
            growingWell = false;
           // warningBar.SetActive(true);
            //deathTimer -= Time.deltaTime;
        }

        if (growingWell == true)
        {
            deathTimer = maxDeathTimer;
        }

        if (growingWell == false)
        {
            warningBar.SetActive(true);
            
        }

        if (warningBar.activeSelf == true)
        {
            deathTimer -= Time.deltaTime;
        }

        if (deadIcon.activeSelf == true)
        {
            growingWell = false;
        }

        if (deathTimer <=0)
        {
            //growingWell = false;
            deadIcon.SetActive(true);
            if (stage1.activeSelf == true)
            {

                stage1anim.Play("Die1");
                sunBar.gameObject.SetActive(false);
                waterBar.gameObject.SetActive(false);
                warningBar.gameObject.SetActive(false);
                refreshable = true;
                if (dieOnce == false)
                {
                    audioSourceC.PlayOneShot(audioClipC);
                    dieOnce = true;
                }
                

            }

            if (stage2.activeSelf == true)
            {

                stage2anim.Play("Die");
                sunBar.gameObject.SetActive(false);
                waterBar.gameObject.SetActive(false);
                warningBar.gameObject.SetActive(false);
                refreshable = true;
                if (dieOnce == false)
                {
                    audioSourceC.PlayOneShot(audioClipC);
                    dieOnce = true;
                }

            }
        }

             
    }




    IEnumerator WaterFill()
    {
        
        yield return new WaitForSeconds(0.8f);
        inWater = false;
        wateringCan = GameObject.FindWithTag("wateringcan");
        if (wateringCan != null)
        {
            wateringCan.SetActive(false);
        }
        
    }

    public void Refresh()
    {
        growingWell = true;
        audioSourceB.PlayOneShot(audioClipB);
        shrinkTimer = timerMax;
        maskSize = 1;
        doOnce = false;
        sunTimer = sunTimerMax;
        waterTimer = waterTimerMax;
        inWater = false;
        sunBar.gameObject.SetActive(true);
        sunAnimator.Play("SunStatic");
        waterBar.gameObject.SetActive(true);
        waterBar.fillAmount = Random.Range(0.3f, 0.8f);
        sunBar.fillAmount = Random.Range(0.3f, 0.8f);
        warningBar.SetActive(false);
        deathTimer -= maxDeathTimer;
        deadIcon.SetActive(false);
        otherDoOnce = false;
        plantSecondStage.SetActive(false);
        plantFirstStage.SetActive(true);
        fullyGrown = false;
        fullCounter = fullCounterMax;
        growStage = 0;
        refreshable = false;
        maskSize = 1;
        dieOnce = false;
        this.gameObject.transform.localScale = new Vector3(this.transform.localScale.x, maskSize, this.transform.localScale.z);

        if (stage1.activeSelf == true)
        {
            stage1anim.SetTrigger("Switch");
        }
        if (stage2.activeSelf == true)
        {
            stage2anim.SetTrigger("Switch");
        }


    }


}
