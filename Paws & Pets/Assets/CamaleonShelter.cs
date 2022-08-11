using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaleonShelter : MonoBehaviour
{
    public GameObject botones;
    public static bool BotonesCamaleonOn;
    public static bool Hambriento;
    public GameObject botonComida;
    public GameObject botonEnfermeria;
    public GameObject botonAdopcion;
    public static bool b_curado;
    public static bool b_listoAdopcion;
    public GameObject heridas;
    void Start()
    {
        botones.SetActive(false);
        Hambriento = true;
        BotonesCamaleonOn = false;
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
        CangrejoShelter.BotonesCangrejoOn = false;
        PerroShelter.BotonesPerroOn = false;
        GatoShelter.BotonesGatoOn = false;

        if (BotonesCamaleonOn)
        {
            botones.SetActive(false);
            BotonesCamaleonOn = false;
        }
        else
        {
            botones.SetActive(true);
            BotonesCamaleonOn = true;
        }
    }    
}
