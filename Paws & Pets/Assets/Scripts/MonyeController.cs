using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonyeController : MonoBehaviour
{
    public static float money=5;
    public Text txt_cantMonedas;
    void Start()
    {       
        //txt_cantMonedas.text = "" + money;
    }
    
    void Update()
    {
        txt_cantMonedas.text = "" + money;
    }
}
