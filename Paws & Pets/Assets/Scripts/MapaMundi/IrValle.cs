using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IrValle : MonoBehaviour
{
    public SpriteRenderer Valle;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (!BotasComprar.Botas)
        {
          Valle.color = Color.black;
          Debug.Log("No puedes pasar sin botas");

        }
        else
        {
            Valle.color = Color.white;
        }
    }

    private void OnMouseDown()
    {

        if (BotasComprar.Botas)
        {
                SceneManager.LoadScene(4);
        }
    }
}
