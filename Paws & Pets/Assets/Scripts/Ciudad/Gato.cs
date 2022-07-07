 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gato : MonoBehaviour
{
    public Camera ZoomGato;
    public GameObject Back;
    public static bool MinijuegoOn;

    public GameObject boton1;
    public GameObject boton2;
    //public Button boton3;

    public GameObject BotonLlevarAlRefugio;

    public Text Dialogo;

    public Collider ColliderGato;

    public GameObject panel;

    void Start()
    {
        Back.SetActive(false);
        Dialogo.gameObject.SetActive(false);
        BotonLlevarAlRefugio.SetActive(false);
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        MinijuegoOn = true;
        ZoomGato.transform.position = new Vector3(-1.08f, -2.22f, -10);
        ZoomGato.orthographicSize = 2.5f;
        Back.SetActive(true);

        //Text textBoton = boton3.GetComponentInChildren<Text>();
        //textBoton.text = ("Dar pescado");

        Dialogo.text = ("Ves un gato lamiendose tranquilamente, hasta que te escucha.\n¿Que haras para romper el hielo?");
        Dialogo.gameObject.SetActive(true);
        boton1.SetActive(true);
        boton2.SetActive(true);
        panel.SetActive(true);
        ColliderGato.enabled = false;
    }

    public void DarPescado()
    {
        if (Anzuelo.contPez++ > 0)
        {
            Dialogo.text = ("Sacas un pescado fresco\nEn el instante en el que el gato lo huele comienza a acercarse mientras maulla\nParece que le gustas");
            Anzuelo.contPez--;
            BotonLlevarAlRefugio.SetActive(true);
        }
        else
        {
            Dialogo.text = ("No tienes ningun pescado\nEl gato se aleja");
            BotonLlevarAlRefugio.SetActive(false);
        }
       
        boton1.SetActive(false);
        boton2.SetActive(false);
       
    }

    public void Acariciar()
    {
        
        Dialogo.text = ("En cuanto te acercas el Gato sale corriendo, lo pierdes de vista\nIntenta darle un pescado la proxima vez antes de acercarte");
        boton1.SetActive(false);
        boton2.SetActive(false);
    }
}
