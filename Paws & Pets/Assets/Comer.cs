using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comer : MonoBehaviour
{
    public GameObject advertencia;
    public static bool NoComida;
    void Start()
    {
        advertencia.SetActive(false);
        NoComida = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (ComprarComida.contComida>0)
        {
            ComprarComida.contComida--;
            if (PerroShelter.BotonesPerroOn)
            {
                PerroShelter.Hambriento = false;
                Debug.Log("Alimentado");
            }
            if (GatoShelter.BotonesGatoOn)
            {
                GatoShelter.Hambriento = false;
                Debug.Log("Alimentado");
            }
            if (CangrejoShelter.BotonesCangrejoOn)
            {
                CangrejoShelter.Hambriento = false;
                Debug.Log("Alimentado");
            }
            if (CamaleonShelter.BotonesCamaleonOn)
            {
                CamaleonShelter.Hambriento = false;
                Debug.Log("Alimentado");
            }
            NoComida = false;
        }
        else
        {
            NoComida = true;
            advertencia.SetActive(true);
            //Instantiate(advertencia);
            Debug.Log("Compra comidaa");
            //cartel
        }
     
    }
}
