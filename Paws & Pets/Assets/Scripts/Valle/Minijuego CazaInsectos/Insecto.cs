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
   
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "modelo_cazainsectos_01")
        {
            Destroy(this.gameObject);
        }
    }
}
