using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiatorPez : MonoBehaviour
{
    public float velDisparo;
    public Rigidbody[] balaPrefab;
    public Transform disparador;
    private Rigidbody balaImpulso;
    public float cont;
    public int rNum;

    void Start()
    {
        cont = 1;
    }

    // Update is called once per frame
    void Update()
    {

        if (CañaDePescar.Jugando)
        {
            cont -= Time.deltaTime;
            velDisparo = Random.Range(1, 5);
            rNum = Random.Range(0, 2); 

            if (cont < 0)
            {
                balaImpulso = Instantiate(balaPrefab[rNum], disparador.position, Quaternion.Euler(0, 180, 0));
                //le añade una fuerza al prefab para que sea disparado
                balaImpulso.AddForce(disparador.right * 100 * velDisparo);
                cont = 3;
            }
        }
    }
}
