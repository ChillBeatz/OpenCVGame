using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartCount : MonoBehaviour
{   
    public int countdown;
    public TextMeshProUGUI STcountdown;

    // Start is called before the first frame update
    void Start()
    {
        countdown = 3;
        StartCoroutine(Startcount());
    }

    IEnumerator Startcount()
    {   
        STcountdown.text = countdown.ToString();

        while(countdown > 0)
        {
            yield return new WaitForSeconds(1);
            countdown--;
            STcountdown.text = countdown.ToString();
        }

        Destroy(STcountdown.gameObject);
    }
}
