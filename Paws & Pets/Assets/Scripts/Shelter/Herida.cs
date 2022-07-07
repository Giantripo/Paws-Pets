using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Herida : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Alcohol"))
        {

        }

        if (other.gameObject.CompareTag("Algodon"))
        {

        }

        if (other.gameObject.CompareTag("Curita"))
        {

        }
    }
}
