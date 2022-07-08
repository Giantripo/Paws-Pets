using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IrAMuelle : MonoBehaviour
{
    public GameObject PlayaFondo;
    public GameObject HiloCaña;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (PlayaFondo.transform.position.x == 22.5f)
        {
            PlayaFondo.transform.position = new Vector2(0f, 0);
            //Flecha.transform.position = new Vector2(9.5f, -1.78f);
            ////OtraFlecha.transform.position = new Vector2(9.8f, -1.78f);
            //Flecha.transform.Rotate(new Vector3(0, -180, 0));
            Debug.Log("Termino todo");
            CañaDePescar.Jugando = false;
            HiloCaña.SetActive(false);

        }
        else
        {
            PlayaFondo.transform.position = new Vector2(22.5f, 0);
            //Flecha.transform.position = new Vector2(-9.5f, -1.99f);
            ////OtraFlecha.transform.position = new Vector2(9.8f, -80.78f);
            //Flecha.transform.Rotate(new Vector3(0, 180, 0));
            
        }
    }
}
