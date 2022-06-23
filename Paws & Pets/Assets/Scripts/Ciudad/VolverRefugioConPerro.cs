using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VolverRefugioConPerro : MonoBehaviour
{
    public static int ContPerros;

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
}
