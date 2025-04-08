using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScore : MonoBehaviour
{
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        SetScoreText();
        Invoke("ExecuteRank", 0.1f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SetScoreText()
    {
        scoreText.text = "YOUR SCORE: " + Score.score.ToString();

        StartCoroutine(Main.Instance.Web.Score(Score.score));
    }
}