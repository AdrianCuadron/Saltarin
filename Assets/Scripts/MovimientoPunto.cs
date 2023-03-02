using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPunto : MonoBehaviour
{

 
    public Rigidbody2D player;

    public static float speedDown;

    public GameObject powerUp;
    // Start is called before the first frame update
    void Start()
    {
        speedDown = CreadorObstaculos.speedDown;
    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<PlayerMovement>() != null && FindObjectOfType<PlayerMovement>().rd.gravityScale == 2)
        {
            
            gameObject.transform.Translate(new Vector3(0, -1, 0) * speedDown * Time.deltaTime);
           
        }
        else
        {
            Destroy(gameObject);
        }

        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<AudioManager>().Play("Power up");
        //ColorUtility.TryParseHtmlString("#45FF6F", out color);
        //punto.color = color;
        //luz.color = color;
        Instantiate(powerUp, transform.position, transform.rotation);
       
        PlayerScore.scoreStatic += 1;

        /*

        CirculoMov.speedDown += 0.1f;
        GiratorioMov.speedDown += 0.1f;
        LadosMov.speedDown += 0.1f;
        MovimientoPunto.speedDown += 0.1f;
        */
        if (CreadorObstaculos.speedDown < 3)
        {
            CreadorObstaculos.speedDown += 0.1f;
            CreadorObstaculos.tiempoRep -= 0.1f;

        }
       
        Destroy(gameObject);


    }
}
