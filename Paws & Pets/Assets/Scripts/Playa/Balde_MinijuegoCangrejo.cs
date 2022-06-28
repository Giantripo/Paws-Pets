using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;

public class Balde_MinijuegoCangrejo : MonoBehaviour
{
    public Camera ZoomBalde;
    public GameObject Back;
    public GameObject Panael;
    public Collider ColliderCangrejo;
    public Animator Crab;

    public Text Dialogo;

    //public 

    void Start()
    {
        Crab.gameObject.SetActive(false);
        Panael.SetActive(false);
        Back.SetActive(false);
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
    }
}
