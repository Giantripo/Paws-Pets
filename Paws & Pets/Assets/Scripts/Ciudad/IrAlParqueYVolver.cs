using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IrAlParqueYVolver : MonoBehaviour
{
    public GameObject CiudadBackGround;
    public GameObject Flecha;
    //public GameObject Flecha2;
    //public Sprite FlechaJardin;
    //public Sprite FlechaJardin2;
    //public GameObject Jardin;
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
            Flecha.transform.position = new Vector2(9.3f, -1.78f);
         
            Flecha.transform.Rotate(new Vector3(0, -180, 0));
        }
        else
        {
            CiudadBackGround.transform.position = new Vector2(-22.53f, 0);
            Flecha.transform.position = new Vector2(-9.3f, -1.78f);
            Flecha.transform.Rotate(new Vector3(0, 180, 0));
           
        }
        
    }

}
