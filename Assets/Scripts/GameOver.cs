using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverText;
    

    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        panel.gameObject.SetActive(false);
        gameOverText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gameOver()
    {
        panel.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        
        Invoke("restart", 2f);
    }

    public void restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
