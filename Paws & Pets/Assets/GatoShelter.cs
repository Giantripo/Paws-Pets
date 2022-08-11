using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatoShelter : MonoBehaviour
{
    public GameObject botones;
    public static bool BotonesGatoOn;
    public static bool Hambriento;
    public GameObject botonComida;
    public GameObject botonEnfermeria;
    public static bool b_curado;
    public GameObject heridas;
    void Start()
    {
        botones.SetActive(false);
        Hambriento = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!Hambriento)
        {
            botonComida.SetActive(false);            
        }
        if (b_curado == true)
        {
            botonEnfermeria.SetActive(false);
            heridas.SetActive(false);            
        }
    }

    private void OnMouseDown()
    {

        if (BotonesGatoOn)
        {
            botones.SetActive(false);
            BotonesGatoOn = false;
        }
        else
        {
            botones.SetActive(true);
            BotonesGatoOn = true;
        }
    }
    
}
