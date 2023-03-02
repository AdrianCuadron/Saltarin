using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorObstaculos : MonoBehaviour
{
    
    public static float tiempoRep;
    public GameObject[] listaObjetos;

    private GameObject obstaculo;
    public GameObject punto;

    public static float speedDown;

    private bool ok = false;
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("instanciar", 0.0f, tiempoRep);
    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<PlayerMovement>() != null && FindObjectOfType<PlayerMovement>().rd.gravityScale == 2 && !ok)
        {
            
            StartCoroutine("instantiator");

            ok = true;
        }
        
        Debug.Log("Tiempo: " + tiempoRep + " ; Speed: " + speedDown);
    }

    /*
    public void invocador()
    {
        InvokeRepeating("instanciar", 0.0f, tiempoRep);
    }

    */

    public void instanciar()
    {
        obstaculo = listaObjetos[Random.Range(0, listaObjetos.Length)];
        Instantiate(obstaculo, obstaculo.transform.position, Quaternion.identity);
        
        Instantiate(punto, new Vector3(0f, obstaculo.transform.position.y, 0f), Quaternion.identity);
       
    }

    IEnumerator instantiator()
    {
        instanciar();
        yield return new WaitForSeconds(tiempoRep);
        

        StartCoroutine("instantiator");
    }
}
