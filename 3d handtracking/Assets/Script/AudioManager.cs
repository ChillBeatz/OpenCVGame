using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip bgm;
    public AudioClip FruitCut;
    //public AudioClip BombCut;

    List<AudioSource> audios = new List<AudioSource>();
    // Start is called before the first frame update
    private void Awake()
    {
        for(int i = 0;i < 2;i++)
        {
            var audio = this.gameObject.AddComponent<AudioSource>();
            audios.Add(audio);
        }
        audios[0].volume = 0.5f;
        audios[1].volume = 0.6f;
    }

    void Start()
    {   
        
    }

    public void Play(int index, string name, bool isLoop)
    {
        var clip = GetAudioClip(name);
        if(clip != null)
        {   
            var audio = audios[index];
            audio.clip = clip;
            audio.loop = isLoop;
            audio.Play();
        }
    }

    AudioClip GetAudioClip(string name)
    {
        switch(name)
        {
            case "bgm":
                return bgm;
            case "FruitCut":
                return FruitCut;
            /*case "BombCut":
                return BombCut;*/
        }
        return null;
    }
}
