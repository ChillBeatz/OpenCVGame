using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public int time;
    public Text timer;

    // Start is called before the first frame update
    void Start()
    {   
        time = 60;
        StartCoroutine(timeCountDown());
    }

    // Update is called once per frame

    IEnumerator timeCountDown()
    {   
        yield return new WaitForSeconds(3);
        timer.text = "TIME: " + time.ToString();

        while(time > 0)
        {
            yield return new WaitForSeconds(1);
            time--;
            timer.text = "TIME: " + time.ToString();
        }

        
        yield return new WaitForSeconds(1);
        Application.LoadLevel("GameOver");
    }
}