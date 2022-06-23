using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VolverRefugio : MonoBehaviour
{
    public static int ContPerros;
    public static int ContGatos;
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    public void VolverConPerro()
    {
        ContPerros++;
        if (ContPerros > 3)
        {
            ContPerros = 3;
        }
        SceneManager.LoadScene(2);
    }

    public void VolverConGato()
    {
        if (ContGatos > 3)
        {
            ContGatos = 3;
        }
        ContGatos++;
        SceneManager.LoadScene(2);
    }
}
