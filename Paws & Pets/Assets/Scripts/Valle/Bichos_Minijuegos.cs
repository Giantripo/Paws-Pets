using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bichos_Minijuegos : MonoBehaviour
{
    public GameObject PlayaFondo;
    public static bool b_minijuegoCazainsectos;


    void Start()
    {
        b_minijuegoCazainsectos = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {

        PlayaFondo.transform.position = new Vector2(-22.5f, 0);
        b_minijuegoCazainsectos = true;

            //Flecha.transform.position = new Vector2(9.5f, -1.78f);
            ////OtraFlecha.transform.position = new Vector2(9.8f, -1.78f);

    }
}
