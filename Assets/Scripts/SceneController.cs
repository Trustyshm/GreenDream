using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey("escape"))
        {
            pauseMenu.SetActive(true);
        }
    }
    
    public void RestartScene()
    {
        Time.timeScale = 1.0f;
        StartCoroutine(RestartSceneDelay());
    }

    public void MenuScreen()
    {
        Time.timeScale = 1.0f;
        StartCoroutine(NextSceneDelay());
        
    }

    IEnumerator NextSceneDelay()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(0);
    }

    IEnumerator RestartSceneDelay()
    {
        yield return new WaitForSeconds(0.3f);
        Scene loadedLevel = SceneManager.GetActiveScene();
        SceneManager.LoadScene(loadedLevel.buildIndex);
    }

}
