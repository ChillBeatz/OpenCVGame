using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static public GameManager instance;
    public GameObject audioManagerPrefab;

    public AudioManager audioManager;
    // Start is called before the first frame update
    void Start()
    {
        if(!instance)
        {
            instance = this;
            //DontDestroyOnLoad(AudioManager);
            audioManager = Instantiate(audioManagerPrefab).GetComponent<AudioManager>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
