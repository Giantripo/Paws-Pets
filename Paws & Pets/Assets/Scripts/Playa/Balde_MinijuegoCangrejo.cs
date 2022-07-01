using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Balde_MinijuegoCangrejo : MonoBehaviour
{
    public Camera ZoomBalde;
    public GameObject Back;
    public GameObject Panael;
    public Collider ColliderCangrejo;
    public Animator Crab;

    public Text Dialogo;

    public GameObject Boton1;
    public GameObject Boton2;
    public GameObject Boton3;

    //public 

    void Start()
    {
        Crab.gameObject.SetActive(false);
        Panael.SetActive(false);
        Back.SetActive(false);
        Boton3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        ColliderCangrejo.enabled = false;
        ZoomBalde.transform.position = new Vector3(-1.08f, -2.22f, -10);
        ZoomBalde.orthographicSize = 2.5f;
        Panael.SetActive(true);
        Crab.gameObject.SetActive(true);
        Back.SetActive(true);
        Dialogo.text = ("Ves un cangrejo que se escondia detras de un balde.\n parece que tiene ganas de pelear");
        Boton1.SetActive(true);
        Boton2.SetActive(true);
    }

    public void PeliarCangrejo()
    {
        Dialogo.text = ("Lo enfrentas con tus guantes a prueba de pelliscos.\nTe has ganado su respeto y te acompaña.");
        Boton1.SetActive(false);
        Boton2.SetActive(false);
        Boton3.SetActive(true);
    }

    public void Acariciar()
    {
        Dialogo.text = ("El cangrejo te pellisca los dedos.\nEso no fue buena idea, la proxima vez intenta utilizar guantes.");
        Boton1.SetActive(false);
        Boton2.SetActive(false);
    }


    public void RefugioConCangrejo()
    {
        SceneManager.LoadScene(2);
    }

}
