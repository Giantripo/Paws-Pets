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
            Debug.Log("No tienes espacio en el refugio para llevarte este perro, debes dar uno en adopcion antes.");
            ContPerros = 3;
        }
        SceneManager.LoadScene(2);
    }

    public void VolverConGato()
    {
        if (ContGatos > 3)
        {
            Debug.Log("No tienes espacio en el refugio para llevarte este gato, debes dar uno en adopcion antes.");
            ContGatos = 3;
        }
        ContGatos++;
        SceneManager.LoadScene(2);
    }
}
