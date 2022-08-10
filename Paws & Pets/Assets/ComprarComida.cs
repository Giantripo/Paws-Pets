using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComprarComida : MonoBehaviour
{
    public static int contComida;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (MonyeController.money >= 5)
        {
            contComida++;
            MonyeController.money -= 5;
            //this.gameObject.SetActive(false);
        }
    }
}
