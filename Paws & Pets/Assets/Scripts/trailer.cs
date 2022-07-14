using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trailer : MonoBehaviour
{
    //private GameObject mousePos;
    //public static bool Jugando;
    //Vector2 objPosition;
    private void OnMouseDrag()
    {
        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Herida" && this.gameObject.name == "algodon")
        {
            Destroy(collision.gameObject,1.5f);

        }
    }
}
