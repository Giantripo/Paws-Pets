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
        if (BotasComprar.Botas)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Valle.color = Color.white;
                SceneManager.LoadScene(4);
            }
           
        }
        else
        {
          
                Valle.color = Color.black;
            if (Input.GetKeyDown(KeyCode.Mouse0))
                Debug.Log("No puedes pasar sin botas");
            
        
        }
    }

    private void OnMouseDown()
    {
        
        
    }
}
