using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CañaDePescar : MonoBehaviour
{
    public GameObject BackGround;
    public GameObject Fondo;
    public GameObject Anzuelo;
    public bool Jugando;

    public new Vector2 Dedo;

    void Start()
    {
        Fondo.SetActive(false);
        Anzuelo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Jugando/* && BackGround.transform.position.x == 22.5f*/)
        //{
            //MecanicaCaña();
            //Dedo.y = Input.mousePosition.y;
            ////Dedo.y = Anzuelo.transform.position.y;
            //Anzuelo.transform.position = Dedo;
        //}
        //else
        //{
        //    Jugando = false;
        //}
    }

    private void OnMouseDown()
    {
        Fondo.SetActive(true);
        Anzuelo.SetActive(true);
        Jugando = true;
    }

    private void OnMouseDrag()
    {
        Vector2 mousePosition = new Vector2(988f, Input.mousePosition.y +180 /*+ transform.position.z*/);
        Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Anzuelo.transform.position = objPosition;
        
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
