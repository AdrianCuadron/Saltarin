using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiratorioMov : MonoBehaviour
{

    public static float speedDown;
    public float speedRot;

    public Rigidbody2D player;

    public Transform giratorio;

    // Start is called before the first frame update
    void Start()
    {
        speedDown = CreadorObstaculos.speedDown;
    }

    // Update is called once per frame
    void Update()
    {
        ;
        
        if (FindObjectOfType<PlayerMovement>() != null && FindObjectOfType<PlayerMovement>().rd.gravityScale == 2) {
            transform.Translate(new Vector3(0, -1, 0) * speedDown * Time.deltaTime);
            giratorio.transform.Rotate(new Vector3(0, 0, 1), speedRot * Time.deltaTime);

        }
        else
        {
            Destroy(gameObject);
        }


        if (gameObject != null && transform.position.y < -9)
        {
            Destroy(gameObject);
        }

    }
}
