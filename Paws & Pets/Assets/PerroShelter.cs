using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerroShelter : MonoBehaviour
{
    public Camera ZoomPerro;
    // Start is called before the first frame update
    void Start()
    {
    
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        //ZoomPerro.transform.position = new Vector3(2.326483f, -2.22f, -10);
        //ZoomPerro.orthographicSize = 2.5f;
        Instantiate(ZoomPerro);
        ZoomPerro.depth = 1;
    }
}
