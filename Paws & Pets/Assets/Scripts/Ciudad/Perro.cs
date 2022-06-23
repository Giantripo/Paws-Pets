using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Perro : MonoBehaviour
{
    public Camera ZoomPerro;
    public GameObject Back;
    public static bool MinijuegoOn;

   
    public Text Dialogo;

    
    void Start()
    {
        Back.SetActive(false);
        Dialogo.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (MinijuegoOn)
        {

            Dialogo.text = ("Ves un perro moviendo la cola, pero parece que no quiere acercarse.\n¿Que haras para romper el hielo?");
            Dialogo.gameObject.SetActive(true);
            
        }
    }

    private void OnMouseDown()
    {
        MinijuegoOn = true;
        ZoomPerro.transform.position = new Vector3(2.326483f, -2.22f, -10);
        ZoomPerro.orthographicSize = 2.5f;
        Back.SetActive(true);

    }
}
