using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Empezar()
    {
        SceneManager.LoadScene(1);
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene(2);
    }
}
