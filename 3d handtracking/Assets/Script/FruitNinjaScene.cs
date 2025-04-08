using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitNinjaScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.audioManager.Play(0, "bgm", true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
