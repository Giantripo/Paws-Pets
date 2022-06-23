using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Perro;
    public Transform Coord1;
    public Transform Coord2;
    public Transform Coord3;

    public GameObject BackGround;

    void Start()
    {
        if (VolverRefugio.ContPerros>0)
        {
            if (VolverRefugio.ContPerros == 1)
            {
                //Perro.transform.SetParent(BackGround.gameObject.transform);
                Instantiate(Perro, Coord1.position, Quaternion.identity, BackGround.transform);
                

            }
            else if(VolverRefugio.ContPerros == 2)
            {
                Instantiate(Perro, Coord1.position, Quaternion.identity, BackGround.transform);
                Instantiate(Perro, Coord2.position, Quaternion.identity, BackGround.transform);
            }
            else if (VolverRefugio.ContPerros >= 3)
            {
                Instantiate(Perro, Coord1.position, Quaternion.identity, BackGround.transform);
                Instantiate(Perro, Coord2.position, Quaternion.identity, BackGround.transform);
                Instantiate(Perro, Coord3.position, Quaternion.identity, BackGround.transform);
            }

        }
        else
        {
            Perro = null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
