using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Adopcion : MonoBehaviour
{
    //public GameObject opcionGato, opcionPerro, opcionCangrejo, opcionCamaleon;
    public GameObject panelExito, panelFracaso;

    public Transform PerroDestruir, GatoD, CamaleonD, CanD;
    void Start()
    {
        panelExito.SetActive(false);
        panelFracaso.SetActive(false);

        
    }

    // Update is called once per frame
    void Update()
    {
        //AdoptarCangrejo();
        //AdoptarCamaleon();
        //AdoptarPerro();
        //AdoptarGato();        
        PerroDestruir = GameObject.Find("fondo_shelter").transform.Find("perro_herido(Clone)");
        GatoD = GameObject.Find("fondo_shelter").transform.Find("gato_herido(Clone)");
        CamaleonD = GameObject.Find("fondo_shelter").transform.Find("camaleon_herido(Clone)");
        CanD = GameObject.Find("fondo_shelter").transform.Find("cangrejo_herido(Clone)");
    }    
    
    public void AdoptarCangrejo()
    {
        if(CangrejoShelter.b_listoAdopcion == true)
        {
            panelExito.SetActive(true);
            CanD.gameObject.SetActive(false);
            VolverRefugio.ContCangrejos--;
        }
        else
        {
            panelFracaso.SetActive(true);
        }
    }

    public void AdoptarCamaleon()
    {
        if (CamaleonShelter.b_listoAdopcion == true)
        {
            panelExito.SetActive(true);
            CamaleonD.gameObject.SetActive(false);
            VolverRefugio.ContCamaleones--;
        }
        else
        {
            panelFracaso.SetActive(true);
        }
    }

    public void AdoptarPerro()
    {
        if (PerroShelter.b_listoAdopcion == true)
        {
            panelExito.SetActive(true);
            PerroDestruir.gameObject.SetActive(false);
            VolverRefugio.ContPerros--;
            //Destroy(PerroDestruir.gameObject);
        }
        else
        {
            panelFracaso.SetActive(true);
        }
    }

    public void AdoptarGato()
    {
        if (GatoShelter.b_listoAdopcion == true)
        {
            panelExito.SetActive(true);
            GatoD.gameObject.SetActive(false);
            VolverRefugio.ContGatos--;
        }
        else
        {
            panelFracaso.SetActive(true);
        }
    }    
}
