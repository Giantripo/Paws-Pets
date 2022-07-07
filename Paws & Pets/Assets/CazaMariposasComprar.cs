using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CazaMariposasComprar : MonoBehaviour
{
    public static bool CazaMariposas;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        CazaMariposas = true;
        this.gameObject.SetActive(false);
    }
}
