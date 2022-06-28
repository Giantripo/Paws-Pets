using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Back_Cangrejo : MonoBehaviour
{
    public Camera ZoomCangrejo;
    public GameObject Back;
    //public Text Dialogo;
    //public GameObject BotonGanar;

    public Collider ColliderCangrejo;

    public GameObject panel;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        ZoomCangrejo.transform.position = new Vector3(0, 0, -10);
        ZoomCangrejo.orthographicSize = 5.034862f;
        Back.SetActive(false);
        //Perro.MinijuegoOn = false;
        //Dialogo.gameObject.SetActive(false);
        //BotonGanar.SetActive(false);
        ColliderCangrejo.enabled = true;
        panel.SetActive(false);

    }
}
