using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Rank : MonoBehaviour
{
    // Start is called before the first frame update
    public Rank Instance;
    public Rank rank;
    public TextMeshProUGUI RankText;
    public GameObject NewHigh;

    void Start()
    {   
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(DataHolder.scoreText == "New Record")
        {
            NewHigh.SetActive(!NewHigh.activeSelf);
        }
        else
        {
            DataHolder.scoreText = "";
        }
        StartCoroutine(Main.Instance.Web.Rank());
        Debug.Log(DataHolder.downloadedText);
        RankText.text = "RANK: " + DataHolder.downloadedText.ToString();
    }
}
