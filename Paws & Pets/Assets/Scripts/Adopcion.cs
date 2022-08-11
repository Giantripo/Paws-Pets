using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Adopcion : MonoBehaviour
{
    //public GameObject opcionGato, opcionPerro, opcionCangrejo, opcionCamaleon;
    public GameObject panelExito, panelFracaso;
    void Start()
    {
        panelExito.SetActive(false);
        panelFracaso.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        AdoptarCangrejo();
        AdoptarCamaleon();
        AdoptarPerro();
        AdoptarGato();        
    }    
    
    public void AdoptarCangrejo()
    {
        if(CangrejoShelter.b_listoAdopcion == true)
        {
            panelExito.SetActive(true);
        }
        else
        {
            panelFracaso.SetActive(false);
        }
    }

    public void AdoptarCamaleon()
    {
        if (CamaleonShelter.b_listoAdopcion == true)
        {
            panelExito.SetActive(true);
        }
        else
        {
            panelFracaso.SetActive(false);
        }
    }

    public void AdoptarPerro()
    {
        if (PerroShelter.b_listoAdopcion == true)
        {
            panelExito.SetActive(true);
        }
        else
        {
            panelFracaso.SetActive(false);
        }
    }

    public void AdoptarGato()
    {
        if (GatoShelter.b_listoAdopcion == true)
        {
            panelExito.SetActive(true);
        }
        else
        {
            panelFracaso.SetActive(false);
        }
    }    
}
