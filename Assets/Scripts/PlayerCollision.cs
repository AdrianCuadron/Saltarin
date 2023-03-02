using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public GameOver gameOver;
    public GameObject dead;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(dead, transform.position, transform.rotation);
        gameObject.SetActive(false);
        Invoke("over",0.5f);
        FindObjectOfType<AudioManager>().Play("Dead");
        


    }

    public void over()
    {
        gameOver.gameOver();
    }
}
