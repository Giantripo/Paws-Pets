using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatoShelter : MonoBehaviour
{
    public GameObject botones;
    public static bool BotonesGatoOn;
    public static bool Hambriento = true;
    public GameObject botonComida;
    public GameObject botonEnfermeria;
    public GameObject botonAdopcion;
    public static bool b_curado;
    public static bool b_listoAdopcion;
    public GameObject heridas;
    void Start()
    {
        botones.SetActive(false);
    
        BotonesGatoOn = false;
        botonAdopcion.SetActive(false);
        b_listoAdopcion = false;
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
        if (Hambriento == false && b_curado == true)
        {
            botonAdopcion.SetActive(true);
            b_listoAdopcion = true;
        }
    }

    private void OnMouseDown()
    {
        CamaleonShelter.BotonesCamaleonOn = false;
        PerroShelter.BotonesPerroOn = false;
        CangrejoShelter.BotonesCangrejoOn = false;

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
