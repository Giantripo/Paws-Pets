using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComidoComprar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if(MonyeController.money >= 5)
        {
            MonyeController.money -= 5;
        }                     
    }
}
