using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaleonShelter : MonoBehaviour
{
    public GameObject botones;
    public static bool BotonesCamaleonOn;
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
