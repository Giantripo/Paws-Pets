using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToAdopcion : MonoBehaviour
{
    public GameObject panel_Adopcion;
    public GameObject flechaShelter;
    void Start()
    {
        panel_Adopcion.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        panel_Adopcion.SetActive(true);
        flechaShelter.SetActive(false);
    }
}
