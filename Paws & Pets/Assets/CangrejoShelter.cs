using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CangrejoShelter : MonoBehaviour
{
    public GameObject botones;
    public static bool BotonesCangrejoOn;
    public static bool Hambriento;
    public GameObject botonComida;
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
    }

    private void OnMouseDown()
    {

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
