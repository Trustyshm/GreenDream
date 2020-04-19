using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainManager : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
        GameObject.FindGameObjectWithTag("titleMusic").GetComponent<TitleMusic>().PlayMusic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        StartCoroutine(SoundDelay());
    }

    public void ExitGame() 
    {
        StartCoroutine(SoundDelayEnd());

    }

    IEnumerator SoundDelay()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    IEnumerator SoundDelayEnd()
    {
        yield return new WaitForSeconds(0.3f);
        QuitGame();
    }

    void QuitGame()
    {
        Application.Quit();
    }
}
