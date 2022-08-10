using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Perro;
    public GameObject Gato;
    public GameObject Cangrejo;
    public GameObject Camaleon;

    public Transform CoordP1;
    public Transform CoordP2;
    public Transform CoordP3;

    public Transform CoordG1;
    public Transform CoordG2;
    public Transform CoordG3;

    public Transform CoordCJ1;
    public Transform CoordCJ2;
    public Transform CoordCJ3;

    public Transform CoordCaJ1;
    public Transform CoordCaJ2;
    public Transform CoordCaJ3;

    public GameObject BackGround;

    void Start()
    {
        GatoNuevo();
        PerroNuevo();
        CangrejoNuevo();
        CamaleonNuevo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PerroNuevo()
    {
        if (VolverRefugio.ContPerros > 0)
        {
            if (VolverRefugio.ContPerros == 1)
            {
                //Perro.transform.SetParent(BackGround.gameObject.transform);
                Instantiate(Perro, CoordP1.position, Quaternion.identity, BackGround.transform);


            }
            else if (VolverRefugio.ContPerros == 2)
            {
                Instantiate(Perro, CoordP1.position, Quaternion.identity, BackGround.transform);
                Instantiate(Perro, CoordP2.position, Quaternion.identity, BackGround.transform);
            }
            else if (VolverRefugio.ContPerros >= 3)
            {
                Instantiate(Perro, CoordP1.position, Quaternion.identity, BackGround.transform);
                Instantiate(Perro, CoordP2.position, Quaternion.identity, BackGround.transform);
                Instantiate(Perro, CoordP3.position, Quaternion.identity, BackGround.transform);
            }

        }
        else
        {
            Perro = null;
        }
    }

    public void GatoNuevo()
    {
        if (VolverRefugio.ContGatos > 0)
        {
            if (VolverRefugio.ContGatos == 1)
            {
                //Perro.transform.SetParent(BackGround.gameObject.transform);
                Instantiate(Gato, CoordG1.position, Quaternion.identity, BackGround.transform);


            }
            else if (VolverRefugio.ContGatos == 2)
            {
                Instantiate(Gato, CoordG1.position, Quaternion.identity, BackGround.transform);
                Instantiate(Gato, CoordG2.position, Quaternion.identity, BackGround.transform);
            }
            else if (VolverRefugio.ContGatos >= 3)
            {
                Instantiate(Gato, CoordG1.position, Quaternion.identity, BackGround.transform);
                Instantiate(Gato, CoordG2.position, Quaternion.identity, BackGround.transform);
                Instantiate(Gato, CoordG3.position, Quaternion.identity, BackGround.transform);
            }

        }
        else
        {
            Gato = null;
        }
    }

    public void CangrejoNuevo()
    {
        if (VolverRefugio.ContCangrejos > 0)
        {
            if (VolverRefugio.ContCangrejos == 1)
            {
                //Perro.transform.SetParent(BackGround.gameObject.transform);
                Instantiate(Cangrejo, CoordCJ1.position, Quaternion.identity, BackGround.transform);


            }
            else if (VolverRefugio.ContCangrejos == 2)
            {
                Instantiate(Cangrejo, CoordCJ1.position, Quaternion.identity, BackGround.transform);
                Instantiate(Cangrejo, CoordCJ2.position, Quaternion.identity, BackGround.transform);
            }
            else if (VolverRefugio.ContCangrejos >= 3)
            {
                Instantiate(Cangrejo, CoordCJ1.position, Quaternion.identity, BackGround.transform);
                Instantiate(Cangrejo, CoordCJ2.position, Quaternion.identity, BackGround.transform);
                Instantiate(Cangrejo, CoordCJ3.position, Quaternion.identity, BackGround.transform);
            }

        }
        else
        {
            Cangrejo = null;
        }
    }

    public void CamaleonNuevo()
    {
        if (VolverRefugio.ContCamaleones > 0)
        {
            if (VolverRefugio.ContCamaleones == 1)
            {
                //Perro.transform.SetParent(BackGround.gameObject.transform);
                Instantiate(Camaleon, CoordCaJ1.position, Quaternion.identity, BackGround.transform);


            }
            else if (VolverRefugio.ContCamaleones == 2)
            {
                Instantiate(Camaleon, CoordCaJ1.position, Quaternion.identity, BackGround.transform);
                Instantiate(Camaleon, CoordCaJ2.position, Quaternion.identity, BackGround.transform);
            }
            else if (VolverRefugio.ContCamaleones >= 3)
            {
                Instantiate(Camaleon, CoordCaJ1.position, Quaternion.identity, BackGround.transform);
                Instantiate(Camaleon, CoordCaJ2.position, Quaternion.identity, BackGround.transform);
                Instantiate(Camaleon, CoordCaJ3.position, Quaternion.identity, BackGround.transform);
            }

        }
        else
        {
            Camaleon = null;
        }
    }
}
