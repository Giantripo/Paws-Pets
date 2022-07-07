using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotasComprar : MonoBehaviour
{
    public static bool Botas;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        Botas = true;
        this.gameObject.SetActive(false);
    }


}
