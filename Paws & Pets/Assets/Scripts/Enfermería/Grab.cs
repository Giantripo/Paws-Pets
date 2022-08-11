using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    private float PosX, PosY;
    public bool b_touching, b_heridaCurada;
    public static bool b_curado;
    public float timer = 2;    
    private void Start()
    {
        PosX = this.gameObject.transform.position.x;
        PosY = this.gameObject.transform.position.y;
        b_touching = false;
        b_heridaCurada = false;
        b_curado = false;       
       
    }
    private void Update()
    {
        if (timer > 0 && b_touching == true)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {               
            Vector2 originalPos = new Vector2(PosX, PosY);
            transform.position = originalPos;           
        }         
    }
    private void OnMouseDrag()
    {
        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;
    }
    private void OnMouseUp()
    {
        Vector2 originalPos = new Vector2(PosX, PosY);
        transform.position = originalPos;        
    }    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Herida" && this.gameObject.name == "algodon")
        {
            b_touching = true;      

        }
        if (collision.name == "Herida" && this.gameObject.name == "Curita")
        {            
            b_heridaCurada = true;
            SpriteRenderer opacidad = collision.gameObject.GetComponent<SpriteRenderer>();
            opacidad.color = new Color(1f, 1f, 1f, 0f);            

        }
        if (collision.name == "Herida" && this.gameObject.name == "alcohol")
        {
            SpriteRenderer opacidad = collision.gameObject.GetComponent<SpriteRenderer>();
            opacidad.color = new Color(1f, 1f, 1f, 0.35f);
            //Destroy(collision.gameObject);

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "Herida" && this.gameObject.name == "algodon")
        {
            if (timer <= 0)
            {                               
                SpriteRenderer opacidad = collision.gameObject.GetComponent<SpriteRenderer>();                 
                opacidad.color = new Color(1f, 1f, 1f, 0.50f);
                b_touching = false;
                timer = 3;
            }

        }
        if (collision.name == "Herida" && this.gameObject.name == "Curita")
        {
            if(b_heridaCurada == true)
            {                
                Vector2 heridaPos = new Vector2(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y);
                gameObject.transform.position = heridaPos;
                Destroy(this.gameObject, 1.5f);                
                Curados();
                //StartCoroutine("VolverShelter");
            }                      
        }      
    }

    public void Curados()
    {
        if(PerroShelter.BotonesPerroOn == true)
        {
            PerroShelter.b_curado = true;
            MonyeController.money += 2.5f;
        }
        if (GatoShelter.BotonesGatoOn == true)
        {
            GatoShelter.b_curado = true;
            MonyeController.money += 2.5f;
        }
        if (CamaleonShelter.BotonesCamaleonOn == true)
        {
            CamaleonShelter.b_curado = true;
            MonyeController.money += 2.5f;
        }
        if (CangrejoShelter.BotonesCangrejoOn == true)
        {
            CangrejoShelter.b_curado = true;
            MonyeController.money += 2.5f;
        }
    }

    //IEnumerator VolverShelter()
    //{     
    //    yield return new WaitForSeconds(3);
    //    b_curado = true;
    //}

}
