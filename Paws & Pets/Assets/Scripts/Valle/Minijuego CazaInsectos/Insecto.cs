using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Insecto : MonoBehaviour
{
    public float insecto_speed;
    private Rigidbody2D rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = transform.right * insecto_speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "modelo_cazainsectos_01")
        {
            if(this.gameObject.tag == "Hoja")
            {
                MonyeController.money--;
                Destroy(this.gameObject);
            }
            if(this.gameObject.tag == "Insecto")
            {
                MonyeController.money++;
                Destroy(this.gameObject);
            }            
        }
        if (collision.name == "collider_tope")
        {         
            Destroy(this.gameObject);
        }
    }
}
