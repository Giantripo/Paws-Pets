using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerrarPerrosCuracion : MonoBehaviour
{
    public Camera ZoomPerro;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        PerroShelter.PerroCuracion = false;
        ZoomPerro.gameObject.SetActive(false);


        //Destroy(this.gameObject);
    }
}
