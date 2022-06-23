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
        SceneManager.LoadScene(2);
    }

    public void VolverConGato()
    {
        ContGatos++;
        SceneManager.LoadScene(2);
    }
}
