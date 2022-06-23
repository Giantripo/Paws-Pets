using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Perro : MonoBehaviour
{
    public Camera ZoomPerro;
    public GameObject Back;
    public static bool MinijuegoOn;

    public GameObject boton1;
    public GameObject boton2;

    public GameObject BotonLlevarAlRefugio;

    public Text Dialogo;

    public Collider ColliderPerro;
    
    void Start()
    {
        Back.SetActive(false);
        Dialogo.gameObject.SetActive(false);
        BotonLlevarAlRefugio.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if (MinijuegoOn)
        //{

        //    Dialogo.text = ("Ves un perro moviendo la cola, pero parece que no quiere acercarse.\n¿Que haras para romper el hielo?");
        //    Dialogo.gameObject.SetActive(true);
            
        //}
    }

    private void OnMouseDown()
    {
        MinijuegoOn = true;
        ZoomPerro.transform.position = new Vector3(2.326483f, -2.22f, -10);
        ZoomPerro.orthographicSize = 2.5f;
        Back.SetActive(true);

        Dialogo.text = ("Ves un perro moviendo la cola, pero parece que no quiere acercarse.\n¿Que haras para romper el hielo?");
        Dialogo.gameObject.SetActive(true);
        boton1.SetActive(true);
        boton2.SetActive(true);
        ColliderPerro.enabled = false;
    }

    public void TirarPelota()
    {
       
        Dialogo.text = ("El perro va corriendo por la pelota y te la regresa en la mano parece que le gustas");
        boton1.SetActive(false);
        boton2.SetActive(false);
        BotonLlevarAlRefugio.SetActive(true);
    }

    public void Acariciar()
    {
        Dialogo.text = ("");
        Dialogo.text = ("En cuanto te acercas el perro corre por todo el jardin, lo pierdes de vista\nIntenta jugar con el la proxima vez antes de acercarte");
        boton1.SetActive(false);
        boton2.SetActive(false);
    }

    
}
