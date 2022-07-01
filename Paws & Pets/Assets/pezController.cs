using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pezController : MonoBehaviour
{

   public GameObject Anzuelo;
    public bool Pesco;
    public Rigidbody pescado;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Pesco)
        {
            this.transform.position = Anzuelo.transform.position;
            pescado.isKinematic = true;
            

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Destroy"))
        {
            Destroy(this.gameObject);
        }

        if (other.gameObject.CompareTag("Anzuelo"))
        {
            Pesco = true;
            //other.transform.position = Pez.transform.position;

        }

    }
}
