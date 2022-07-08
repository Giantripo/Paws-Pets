using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPedra : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!CañaDePescar.Jugando)
        {
            Destroy(this.gameObject);
        }
    }
}
