using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerroShelter : MonoBehaviour
{
    public Camera ZoomPerro;
    public static bool PerroCuracion;
    public GameObject PackCuracion;
    public Collider PerroCollider;
    public GameObject BotonVolver;
    // Start is called before the first frame update
    void Start()
    {
    
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!PerroCuracion)
        {
            PackCuracion.SetActive(false);
            PerroCollider.enabled = true;
        
        }
        else
        {

        }
     
    }

    private void OnMouseDown()
    {
        //if (!PerroCuracion)
        //{
        //ZoomPerro.transform.position = new Vector3(2.326483f, -2.22f, -10);
        //ZoomPerro.orthographicSize = 2.5f;
        if (Instantiate(ZoomPerro))
        {
            ZoomPerro.gameObject.SetActive(true);
        }
        else
        {
            Instantiate(ZoomPerro);
        }
           
            //ZoomPerro.depth = 1;
            PackCuracion.SetActive(true);
            PerroCollider.enabled = false;
            Instantiate(BotonVolver);


            PerroCuracion = true;

        //}
    }
}
