using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalEnEnfermeria : MonoBehaviour
{
    public GameObject pero1;
    void Start()
    {
        if (PerroShelter.perro1)
        {
            Instantiate(pero1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
