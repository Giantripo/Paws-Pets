using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VolverRefugio : MonoBehaviour
{
    public static int ContPerros;
    public static int ContGatos;
    public static int ContCangrejos;
    public static int ContCamaleones;
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

    public void VolverConCangrejo()
    {
        if (ContCangrejos > 3)
        {
            Debug.Log("No tienes espacio en el refugio para llevarte este gato, debes dar uno en adopcion antes.");
            ContCangrejos = 3;
        }
        ContCangrejos++;
        SceneManager.LoadScene(2);
    }

    public void VolverConCamaleon()
    {
        //if (ContGatos > 3)
        //{
        //    Debug.Log("No tienes espacio en el refugio para llevarte este gato, debes dar uno en adopcion antes.");
        //    ContGatos = 3;
        //}
        //ContGatos++;
        SceneManager.LoadScene(2);
    }

    public void MapaMundi()
    {
        SceneManager.LoadScene(5);
    }
}
