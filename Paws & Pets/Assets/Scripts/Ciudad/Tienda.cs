using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tienda : MonoBehaviour
{
    public GameObject TiendaAbierta;
    void Start()
    {
        TiendaAbierta.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("Abrir_Tienda");
        TiendaAbierta.SetActive(true);

    }


}
