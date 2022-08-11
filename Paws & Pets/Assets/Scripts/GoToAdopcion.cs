using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToAdopcion : MonoBehaviour
{
    //public GameObject panel_Adopcion;
    //public GameObject flechaShelter;
    public static bool b_goToAdopcion;
    void Start()
    {
        b_goToAdopcion = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        b_goToAdopcion = true;
    }
}
