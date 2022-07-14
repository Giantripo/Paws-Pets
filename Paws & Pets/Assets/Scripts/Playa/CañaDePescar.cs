using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CañaDePescar : MonoBehaviour
{
    public GameObject BackGround;
    public GameObject Fondo;
    public GameObject Anzuelo;
    public static bool Jugando;
    Vector2 objPosition;

    public GameObject PlayaFondo;

    //public new Vector2 Dedo;

    void Start()
    {
        Fondo.SetActive(false);
        Anzuelo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if (BackGround.transform.position.x == 22.5f)
        //{
        //    Jugando = true;
        //}
        //else
        //{
        //    Jugando = false;
        //}

        //if (AnzueloComprar.ContAnzuelos <= 0)
        //{
        //    Jugando = false;
        //    Anzuelo.SetActive(false);
        //}

            if (Anzuelo.transform.position.y < -2)
        {
            Anzuelo.transform.position = new Vector2(2.6f, -2f);
        }

        if (Anzuelo.transform.position.y > 3.3f )
        {

            Anzuelo.transform.position = new Vector2(2.6f, 3.3f);
        }
    }

    private void OnMouseDown()
    {
        //if (Jugando)
        //{
            
        //}
        //if (AnzueloComprar.ContAnzuelos > 0)
        //{
            Fondo.SetActive(true);
            Anzuelo.SetActive(true);
            Jugando = true;
           
        //}
        //else
        //{
        //    Debug.Log("Necesitas Anzuelos");
        //}
    }

    private void OnMouseDrag()
    {
        //if (AnzueloComprar.ContAnzuelos > 0)
        {


            if (Jugando)
            {


                Vector2 mousePosition = new Vector2(988f, Input.mousePosition.y + 180 /*+ transform.position.z*/);
                objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
                Anzuelo.transform.position = objPosition;
            }
        //}
        //else
        //{
        //    Debug.Log("Necesitas Anzuelos");
        }
    }


    public void MecanicaCaña()
    {
        //Dedo = Input.mousePosition;
        //Dedo.y = Anzuelo.transform.position.y;
        
    }

    public void LimiteAnzuelo()
    {
        if (Anzuelo.transform.position.y > 0 )
        {
            Anzuelo.transform.position = new Vector3(0, -6f, 0) * Time.deltaTime;
        }
    }
}
