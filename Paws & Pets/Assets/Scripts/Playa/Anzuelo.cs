using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anzuelo : MonoBehaviour
{
    public static bool Pesco;
    public Rigidbody Pez;
    //public Rigidbody pescado;
    public GameObject hilo;
    public static int contPez;
    //void Start()
    //{

    //}

    //// Update is called once per frame
    void Update()
    {
        if (Pesco)
        {
     
            //se frenee
        }
        else
        {
       
        }
    }

    public void DestroyPez()
    {
       
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pez"))
        {
            Pesco = true;
            //Pez.isKinematic = true;

            other.transform.SetParent(hilo.transform);
            other.attachedRigidbody.isKinematic = true;

            Debug.Log("true");
            //Pez.position = hilo.transform.position;
        }

        if (other.gameObject.CompareTag("Piedra"))
        {
            AnzueloComprar.ContAnzuelos--;
        }

        if (other.gameObject.CompareTag("Zapato"))
        {
            AnzueloComprar.ContAnzuelos--;
        }

        //}


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Pez"))
        {
            Pesco = false;
            Debug.Log("Falso");
            //Pez.position = hilo.transform.position;
        }

        //}


    }
}
