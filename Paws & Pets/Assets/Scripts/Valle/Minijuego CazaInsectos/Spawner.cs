using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] insecto;
    public GameObject hoja;
    //public float timeToSpawn;
    //private float currentTimeToSpawn; 

    public float xBounds, yBounds;
    Vector2 objPosition;
    public float timer;
    void Start()
    {
        timer = Random.Range(1, 3);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(Bichos_Minijuegos.b_minijuegoCazainsectos == true)
        {
            Instantiator();
        }        
        //else
        //{
        //    Debug.Log("false");
        //}
    }

    //IEnumerator SpawnObject()
    //{
    //    if (Bichos_Minijuegos.b_minijuegoCazainsectos == true)
    //    {
    //        yield return new WaitForSeconds(Random.Range(1, 3));
    //        int randomnum = Random.Range(0, 4);
    //        if (Random.value <= .6f)
    //        {
    //            Instantiate(insecto[randomnum], new Vector2(xBounds, Random.Range(-yBounds, yBounds)), Quaternion.identity);
    //        }
    //        else
    //        {
    //            Instantiate(hoja, new Vector2(xBounds, Random.Range(-yBounds, yBounds)), Quaternion.identity);
    //        }
    //        //Instantiate(insecto[randomnum], transform.position, insecto[randomnum].transform.rotation);
    //        StartCoroutine(SpawnObject());
    //    }        
    //}

    public void Instantiator()
    {
        if(timer <= 0)
        {
            int randomnum = Random.Range(0, 4);
            if (Random.value <= .6f)
            {
                Instantiate(insecto[randomnum], new Vector2(xBounds, Random.Range(-yBounds, yBounds)), Quaternion.identity);
            }
            else
            {
                Instantiate(hoja, new Vector2(xBounds, Random.Range(-yBounds, yBounds)), Quaternion.identity);
            }
            timer = Random.Range(1, 3);
        }        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Insecto"))
        {
            //add point;
            //play TLIN
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Hoja"))
        {
            //remove point;
            //play wrong
            Destroy(collision.gameObject);
        }
    }

    //private void OnMouseDrag()
    //{

    //    Vector2 mousePosition = new Vector2(988f, Input.mousePosition.y + 180 /*+ transform.position.z*/);
    //    objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
    //    this.gameObject.transform.position = objPosition;


    //}
}
