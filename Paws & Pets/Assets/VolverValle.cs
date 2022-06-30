using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolverValle : MonoBehaviour
{
    public GameObject PlayaFondo;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnMouseDown()
    {
       
        
            PlayaFondo.transform.position = new Vector2(0f, 0);
            //Flecha.transform.position = new Vector2(9.5f, -1.78f);
            ////OtraFlecha.transform.position = new Vector2(9.8f, -1.78f);
            //Flecha.transform.Rotate(new Vector3(0, -180, 0));
        

    }
}
