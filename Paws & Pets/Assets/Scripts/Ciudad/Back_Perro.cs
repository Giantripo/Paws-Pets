using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Back_Perro : MonoBehaviour
{
    public Camera ZoomPerro;
    public GameObject Back;
    public Text Dialogo;
    public GameObject BotonGanar;

    public Collider ColliderPerro;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        ZoomPerro.transform.position = new Vector3(0, 0, -10);
        ZoomPerro.orthographicSize = 5.034862f;
        Back.SetActive(false);
        Perro.MinijuegoOn = false;
        Dialogo.gameObject.SetActive(false);
        BotonGanar.SetActive(false);
        ColliderPerro.enabled=true;
    }
}
