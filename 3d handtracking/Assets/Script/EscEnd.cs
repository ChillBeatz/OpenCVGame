using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscEnd : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {   
            Debug.Log("esc");
            Application.Quit();
        }
    }
}
