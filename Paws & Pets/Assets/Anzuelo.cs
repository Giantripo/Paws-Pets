using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anzuelo : MonoBehaviour
{
    public bool Pesco;
    public Rigidbody Pez;
    //public Rigidbody pescado;
    public GameObject hilo;
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pez"))
        {
            Pesco = true;
            //Pez.isKinematic = true;

            other.transform.SetParent(hilo.transform);
            

            //Pez.position = hilo.transform.position;
        }

        //}


    }

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Pez"))
    //    {
    //        Pesco = false;

    //        //Pez.position = hilo.transform.position;
    //    }

    //    //}


    //}
}
