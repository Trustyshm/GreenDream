using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class tutorialController : MonoBehaviour
{

    public Animator fadeAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(LoadNext());
        
    }

    IEnumerator LoadNext()
    {
        yield return new WaitForSeconds(10f);
        fadeAnimator.Play("uiFadeOut");
        yield return new WaitForSeconds(1.5f);
        GameObject.FindGameObjectWithTag("titleMusic").GetComponent<TitleMusic>().StopMusic();
        NextScene();
    }

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
