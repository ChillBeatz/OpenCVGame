using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackTItle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BacktoTitle()
    {   
        Score.score = 0;
        DataHolder.scoreText = "";
        Application.LoadLevel("StartTitle");
    }
}
