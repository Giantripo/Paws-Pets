using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTope : MonoBehaviour
{
    //public GameObject Pez;
    //public GameObject Zapato;
    //public GameObject Pedra;
    void Start()
    {
        
    }

    // Update is called once per fram

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Piedra"))
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Zapato"))
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Pez"))
        {
            Destroy(other.gameObject);
        }
    }

}
