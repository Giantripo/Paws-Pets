using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Back_Gato : MonoBehaviour
{
    public Camera ZoomGato;
    public GameObject Back;
    public Text Dialogo;
    public GameObject BotonGanar;

    public Collider ColliderGato;

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
        ZoomGato.transform.position = new Vector3(0, 0, -10);
        ZoomGato.orthographicSize = 5.034862f;
        Back.SetActive(false);
        Perro.MinijuegoOn = false;
        Dialogo.gameObject.SetActive(false);
        BotonGanar.SetActive(false);
        ColliderGato.enabled = true;
        panel.SetActive(false);
    }
}
