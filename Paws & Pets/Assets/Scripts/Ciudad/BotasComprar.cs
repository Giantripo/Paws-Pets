using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotasComprar : MonoBehaviour
{
    public static bool Botas;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Botas == true)
        {

            this.gameObject.SetActive(false);
        }
    }

    private void OnMouseDown()
    {
        if(MonyeController.money >= 5)
        {
            Botas = true;
            MonyeController.money -= 5;
            //this.gameObject.SetActive(false);
        }        
    }


}
