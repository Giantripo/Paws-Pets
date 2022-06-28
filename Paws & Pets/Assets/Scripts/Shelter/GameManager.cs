using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Perro;
    public GameObject Gato;
    public Transform CoordP1;
    public Transform CoordP2;
    public Transform CoordP3;

    public Transform CoordG1;
    public Transform CoordG2;
    public Transform CoordG3;

    public GameObject BackGround;

    void Start()
    {
        GatoNuevo();
        PerroNuevo();
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
}
