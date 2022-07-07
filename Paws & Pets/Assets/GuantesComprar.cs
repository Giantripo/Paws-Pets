using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuantesComprar : MonoBehaviour
{
    public static bool Guantes;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Guantes = true;
        this.gameObject.SetActive(false);

        //if (plata >=10)
        //{
        //    Debug.Log("Comprado");
        //}
        //else
        //{
        //    Debug.Log("No te alcanza");
        //}
    }
}
