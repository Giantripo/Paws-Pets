using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] insecto;
    public float timeToSpawn;
    private float currentTimeToSpawn;    
    void Start()
    {        
    }

    // Update is called once per frame
    void Update()
    {
        if(currentTimeToSpawn > 0)
        {
            currentTimeToSpawn -= Time.deltaTime;
        }
        else
        {
            SpawnObject();
            currentTimeToSpawn = timeToSpawn;
        }
    }

    public void SpawnObject()
    {
        int randomnum = Random.Range(0,4);
        Instantiate(insecto[randomnum], transform.position, insecto[randomnum].transform.rotation);
    }
}
