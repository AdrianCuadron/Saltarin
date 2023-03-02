using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rd;
    public Vector2 velocity;

    public GameObject humo;
    public static bool empezado= false;

    public Text tapToPlay;
    // Start is called before the first frame update
    void Start()
    {
        
        newGame();
        

    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetMouseButtonDown(0) || Input.GetKeyDown("up")) && !GameManager.isPaused)
        {
            PlayerMovement.empezado = true;
            humo.gameObject.SetActive(true);
            tapToPlay.gameObject.SetActive(false);
            rd.gravityScale = 2f;
            
            rd.velocity=velocity;
            
        }

        

    }

    public void newGame()
    {
        gameObject.transform.position = new Vector3(0f, -2f, 0f);
        rd.gravityScale = 0;
        gameObject.SetActive(true);
        humo.gameObject.SetActive(false);
        tapToPlay.gameObject.SetActive(true);
        PlayerScore.scoreStatic = 0;
        PlayerMovement.empezado = false;

        //Velocidad

        CirculoMov.speedDown = 1.7f;
        LadosMov.speedDown = 1.7f;
        GiratorioMov.speedDown = 1.7f;
        MovimientoPunto.speedDown = 1.7f;

        CreadorObstaculos.speedDown = 1.8f;
        CreadorObstaculos.tiempoRep = 2.75f;
    }

    

    
}
