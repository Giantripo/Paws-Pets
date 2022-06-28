using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balde_MinijuegoCangrejo : MonoBehaviour
{
    public Camera ZoomBalde;
    //public GameObject Back;
    public GameObject Panael;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        ZoomBalde.transform.position = new Vector3(-1.08f, -2.22f, -10);
        ZoomBalde.orthographicSize = 2.5f;
    }
}
