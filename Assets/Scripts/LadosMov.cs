using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadosMov : MonoBehaviour
{

    public static float speedDown;
    public float speedLado;

    private int dirX;
    

    public Transform lado;

    // Start is called before the first frame update
    void Start()
    {
        dirX = 1;
        speedDown = CreadorObstaculos.speedDown;
    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<PlayerMovement>() != null && FindObjectOfType<PlayerMovement>().rd.gravityScale == 2)
        {
            transform.Translate(new Vector3(0, -1, 0) * speedDown * Time.deltaTime);
            lado.transform.Translate(new Vector3(dirX, 0, 0) * speedLado * Time.deltaTime);

        }
        else
        {
            Destroy(gameObject);
        }

        if (gameObject != null && transform.position.y < -9)
        {
            Destroy(gameObject);
        }

        if (lado.transform.position.x < -2)
        {
            dirX = 1;
        }
        else if (lado.transform.position.x > 2)
        {
            dirX = -1;
        }
        
    }
}
