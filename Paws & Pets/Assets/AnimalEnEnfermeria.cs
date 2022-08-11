using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimalEnEnfermeria : MonoBehaviour
{
    public GameObject perro,gato,camaleon,cangrejo;
    void Start()
    {
        perro.SetActive(false);
        camaleon.SetActive(false);
        cangrejo.SetActive(false);
        gato.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(PerroShelter.BotonesPerroOn == true)
        {
            perro.SetActive(true);
            camaleon.SetActive(false);
            cangrejo.SetActive(false);
            gato.SetActive(false);
        }
        if(GatoShelter.BotonesGatoOn == true)
        {
            gato.SetActive(true);
            perro.SetActive(false);
            camaleon.SetActive(false);
            cangrejo.SetActive(false);
        }
        if (CamaleonShelter.BotonesCamaleonOn == true)
        {
            camaleon.SetActive(true);
            cangrejo.SetActive(false);
            gato.SetActive(false);
            perro.SetActive(false);
        }
        if (CangrejoShelter.BotonesCangrejoOn == true)
        {
            cangrejo.SetActive(true);
            gato.SetActive(false);
            perro.SetActive(false);
            camaleon.SetActive(false);            
        }

        //if (Grab.b_curado == true)
        //{           
        //    SceneManager.LoadScene("Shelter");
        //}

    }
}
