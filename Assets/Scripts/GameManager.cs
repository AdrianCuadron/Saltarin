using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject panel;
    public GameObject resumeBut;
    public GameObject restartBut;
    public GameObject optionsBut;
    public GameObject quitBut;

    public PlayerMovement playerMovement;

    public static bool isPaused;

    
    // Start is called before the first frame update
    void Start()
    {
        panel.gameObject.SetActive(false);
        resumeBut.gameObject.SetActive(false);
        restartBut.gameObject.SetActive(false);
        optionsBut.gameObject.SetActive(false);
        quitBut.gameObject.SetActive(false);

        GameManager.isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void paused()
    {
        panel.gameObject.SetActive(true);
        Time.timeScale = 0f;
        resumeBut.gameObject.SetActive(true);
        restartBut.gameObject.SetActive(true);
        optionsBut.gameObject.SetActive(true);
        quitBut.gameObject.SetActive(true);

        GameManager.isPaused = true;

    }
    public void resume()
    {
        panel.gameObject.SetActive(false);
        resumeBut.gameObject.SetActive(false);
        restartBut.gameObject.SetActive(false);
        optionsBut.gameObject.SetActive(false);
        quitBut.gameObject.SetActive(false);
        Time.timeScale = 1f;
        GameManager.isPaused = false;
    }

    public void quit()
    {
        Application.Quit();
    }

    public void options()
    {
        Debug.Log("Options");
    }

    public void restart()
    {
        resume();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
