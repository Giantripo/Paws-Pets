using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerrarTienda : MonoBehaviour
{
    public GameObject Tienda;
    public GameObject Precios;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Tienda.SetActive(false);
        Precios.SetActive(false);
    }
}
