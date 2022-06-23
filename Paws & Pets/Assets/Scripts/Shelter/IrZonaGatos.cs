using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IrZonaGatos : MonoBehaviour
{
    public GameObject CiudadBackGround;
    public GameObject Flecha;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (CiudadBackGround.transform.position.x == 22.5f)
        {
            CiudadBackGround.transform.position = new Vector2(46.48f, 0);
            Flecha.transform.position = new Vector2(10.11f, -1.78f);
            //OtraFlecha.transform.position = new Vector2(9.8f, -1.78f);
        }
        else
        {
            CiudadBackGround.transform.position = new Vector2(22.5f, 0);
            Flecha.transform.position = new Vector2(-10.736f, -1.99f);
            //OtraFlecha.transform.position = new Vector2(9.8f, -80.78f);

        }

    }
}
