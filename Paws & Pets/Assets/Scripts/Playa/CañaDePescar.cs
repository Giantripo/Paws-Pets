using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CañaDePescar : MonoBehaviour
{
    public GameObject Fondo;
    public GameObject Anzuelo;
    void Start()
    {
        Fondo.SetActive(false);
        Anzuelo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Fondo.SetActive(true);
        Anzuelo.SetActive(true);
    }
}
