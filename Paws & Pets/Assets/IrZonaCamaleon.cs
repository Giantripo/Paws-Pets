using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IrZonaCamaleon : MonoBehaviour
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
        if (CiudadBackGround.transform.position.x == 68.48f)
        {
            CiudadBackGround.transform.position = new Vector2(93f, 0);
            Flecha.transform.position = new Vector2(9.5f, -1.78f);
            //OtraFlecha.transform.position = new Vector2(9.8f, -1.78f);
            Flecha.transform.Rotate(new Vector3(0, -180, 0));
        }
        else
        {
            CiudadBackGround.transform.position = new Vector2(68.48f, 0);
            Flecha.transform.position = new Vector2(-9.5f, -1.99f);
            //OtraFlecha.transform.position = new Vector2(9.8f, -80.78f);
            Flecha.transform.Rotate(new Vector3(0, 180, 0));

        }

    }
}
