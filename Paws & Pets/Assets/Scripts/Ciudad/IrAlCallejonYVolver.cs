using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IrAlCallejonYVolver : MonoBehaviour
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
        if (CiudadBackGround.transform.position.x == -22.53f)
        {
            CiudadBackGround.transform.position = new Vector2(0.01f, 0);
            Flecha.transform.position = new Vector2(9.99f, -1.78f);
        }
        else
        {
            CiudadBackGround.transform.position = new Vector2(-22.53f, 0);
            Flecha.transform.position = new Vector2(-9.83f, -1.78f);

        }

    }

}
