using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public static int scoreStatic;
    public int score = 0;
    public int highScore;
    public Text scoreText;
    public GameObject highScoreText;
    public Text recordText;

    public bool newHighScore= false;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        PlayerScore.scoreStatic = 0;
        highScoreText.gameObject.SetActive(false);
        highScore= PlayerPrefs.GetInt("HighScore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        score = PlayerScore.scoreStatic;
        scoreText.text = "" + score;
        
        newHighScore = false;
        if (score > highScore && !newHighScore)
        {
            
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
            newHighScore = true;
            highScoreText.gameObject.SetActive(true);
            Invoke("desactivar", 1.5f);
            
        }

        if (newHighScore)
        {

            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
        }
        recordText.text = "Record: " + highScore;

        
    }

    public void desactivar()
    {
        highScoreText.gameObject.SetActive(false);
    }

    
}
