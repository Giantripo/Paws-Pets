using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CangrejoShelter : MonoBehaviour
{
    public GameObject botones;
    public static bool BotonesCangrejoOn;
    public static bool Hambriento;
    public GameObject botonComida;
    public GameObject botonEnfermeria;
    public static bool b_curado;
    public GameObject heridas;
    void Start()
    {
        botones.SetActive(false);
        Hambriento = true;
        BotonesCangrejoOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!Hambriento)
        {
            botonComida.SetActive(false);
        }
        if(b_curado == true)
        {
            botonEnfermeria.SetActive(false);
            heridas.SetActive(false);
        }
    }

    private void OnMouseDown()
    {
        CamaleonShelter.BotonesCamaleonOn = false;
        PerroShelter.BotonesPerroOn = false;
        GatoShelter.BotonesGatoOn = false;

        if (BotonesCangrejoOn)
        {
            botones.SetActive(false);
            BotonesCangrejoOn = false;
        }
        else
        {
            botones.SetActive(true);
            BotonesCangrejoOn = true;
        }
    }
    
}
