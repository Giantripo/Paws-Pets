using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PerroShelter : MonoBehaviour
{
    //public Camera ZoomPerro;
    //public static bool PerroCuracion;
    //public GameObject PackCuracion;
    //public Collider PerroCollider;
    //public GameObject BotonVolver;
    //public static bool perro1;

    public GameObject botones;
    public static bool BotonesPerroOn;
    public GameObject botonComida;
    public GameObject botonEnfermeria;
    public static bool b_curado;
    public static bool Hambriento;
    public GameObject heridas;
    private bool b_sumadoH, b_sumadoC;

    // Start is called before the first frame update
    void Start()
    {
        botones.SetActive(false);
        Hambriento = true;
        b_sumadoC = false;
        b_sumadoH = false;
        BotonesPerroOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!Hambriento)
        {
            botonComida.SetActive(false);
        }
        if (b_curado == true)
        {
            botonEnfermeria.SetActive(false);
            heridas.SetActive(false);
        }
        //Recompensa();
    }

    //public void Recompensa()
    //{
    //    if(b_curado == true && b_sumadoC == false)
    //    {
    //        MonyeController.money += 10;
    //        b_sumadoC = true;
    //    }
    //    if(Hambriento == false && b_sumadoH == false)
    //    {
    //        MonyeController.money += 3;
    //        b_sumadoH = true;
    //    }
    //}

    private void OnMouseDown()
    {
        CamaleonShelter.BotonesCamaleonOn = false;
        CangrejoShelter.BotonesCangrejoOn = false;
        GatoShelter.BotonesGatoOn = false;

        if (BotonesPerroOn)
        {
            botones.SetActive(false);
            BotonesPerroOn = false;
        }
        else
        {
            
            botones.SetActive(true);
            BotonesPerroOn = true;

        }     

        //perro1 = true;
        //SceneManager.LoadScene(6);



        //if (!PerroCuracion)
        //{
        //ZoomPerro.transform.position = new Vector3(2.326483f, -2.22f, -10);
        //ZoomPerro.orthographicSize = 2.5f;
        //if (Instantiate(ZoomPerro))
        //{
        //    ZoomPerro.gameObject.SetActive(true);
        //}
        //else
        //{
        //    Instantiate(ZoomPerro);
        //}

        //    //ZoomPerro.depth = 1;
        //    PackCuracion.SetActive(true);
        //    PerroCollider.enabled = false;
        //    Instantiate(BotonVolver);


        //    PerroCuracion = true;

        //}
    }    
}
