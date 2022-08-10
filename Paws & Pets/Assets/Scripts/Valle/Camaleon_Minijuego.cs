using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Camaleon_Minijuego : MonoBehaviour
{
    public GameObject PlayaFondo;
    public GameObject Panel;
    public GameObject mapa;
    public GameObject botones;
    public GameObject VolverAlRefugioBtn;

    public Text Texto;
    void Start()
    {
        
        Panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (PlayaFondo.transform.position.x == 22.5f)
        {
            PlayaFondo.transform.position = new Vector2(0f, 0);
            //Flecha.transform.position = new Vector2(9.5f, -1.78f);
            ////OtraFlecha.transform.position = new Vector2(9.8f, -1.78f);
            //Flecha.transform.Rotate(new Vector3(0, -180, 0));
            mapa.SetActive(true);
        }
        else
        {
            PlayaFondo.transform.position = new Vector2(0f, -10.7f);

            Texto.text = "Te encuentras un camaleon entre las hojas.\nEsta herido y se ve hambriento";
            botones.SetActive(true);
            VolverAlRefugioBtn.SetActive(false);

            Panel.SetActive(true);
            mapa.SetActive(false);

        }
    }

    public void Alimentar()
    {
        if (Bichos_Minijuegos.bichosCont>0)
        {
            Texto.text = "El camaleon se acerca lentamente y estira su lengua comiendo al instante el insecto que le ofreciste. Parece que le agradas y te acompaña";
            botones.SetActive(false);
            VolverAlRefugioBtn.SetActive(true);
        }
        else
        {
            Texto.text = "No tienes ningun insecto.\nEl camaleon estira su lengua y te golpea en la cara";
            botones.SetActive(false);
            VolverAlRefugioBtn.SetActive(false);
        }
        
        //botones.SetActive(false);
        //VolverAlRefugioBtn.SetActive(true);
    }

    public void Acariciar()
    {
        Texto.text = "El camaleon se aleja asustado.\nSe camufla con el entorno";
        botones.SetActive(false);
    }

}
