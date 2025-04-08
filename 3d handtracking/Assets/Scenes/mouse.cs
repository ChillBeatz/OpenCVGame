using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class Score
{
    public static int score;

    static Score()
    {
        score = 0;
    }
}

public class mouse : MonoBehaviour
{
    // Start is called before the first frame update
    Collider collider;
    public Text scoreText;

    void Start()
    {   
        SetScoreText();
        collider = gameObject.GetComponent<Collider>();
        collider.enabled = false;
    }

    // Update is called once per frame
    Vector3 vect;
    void Update()
    {
        /*if(Input.GetMouseButton(0))
        {
            vect = Input.mousePosition;
            vect.z = 10;
            gameObject.transform.position = Camera.main.ScreenToWorldPoint(vect);
            collider.enabled = true;
        }*/

        vect = Input.mousePosition;
        vect.z = 10;
        gameObject.transform.position = Camera.main.ScreenToWorldPoint(vect);
        collider.enabled = true;


        /*if (Input.GetMouseButtonDown(0))
        {
            collider.enabled = true;

        }
        if (Input.GetMouseButtonUp(0))
        {
            collider.enabled = false;

        }*/
    }
    GameObject up, down;
    private void OnTriggerEnter(Collider other)
    {
       if(other.tag == "apple")
        {   
            GameManager.instance.audioManager.Play(1, "FruitCut", false);
            up = other.gameObject.transform.GetChild(0).gameObject;
            down = other.gameObject.transform.GetChild(1).gameObject;

            down.transform.parent = null;
            up.transform.parent = null;
            GameObject.Destroy(other.gameObject);

            down.GetComponent<Rigidbody>().isKinematic = false;
            up.GetComponent<Rigidbody>().isKinematic = false;

            down.GetComponent<Rigidbody>().AddRelativeForce(0,0,Random.Range(50,100));
            up.GetComponent<Rigidbody>().AddRelativeForce(0, 0,-Random.Range(50, 100));

            Score.score += 5;
            SetScoreText();
        }

        if(other.tag == "orange")
        {   
            GameManager.instance.audioManager.Play(1, "FruitCut", false);
            up = other.gameObject.transform.GetChild(0).gameObject;
            down = other.gameObject.transform.GetChild(1).gameObject;

            down.transform.parent = null;
            up.transform.parent = null;
            GameObject.Destroy(other.gameObject);

            down.GetComponent<Rigidbody>().isKinematic = false;
            up.GetComponent<Rigidbody>().isKinematic = false;

            down.GetComponent<Rigidbody>().AddRelativeForce(Random.Range(50, 100), Random.Range(50, 100), 0);
            up.GetComponent<Rigidbody>().AddRelativeForce(-Random.Range(50, 100), -Random.Range(50, 100), 0);
            
            Score.score += 5;
            SetScoreText();
        }

        if(other.tag == "lemon")
        {   
            GameManager.instance.audioManager.Play(1, "FruitCut", false);
            up = other.gameObject.transform.GetChild(0).gameObject;
            down = other.gameObject.transform.GetChild(1).gameObject;

            down.transform.parent = null;
            up.transform.parent = null;
            GameObject.Destroy(other.gameObject);

            down.GetComponent<Rigidbody>().isKinematic = false;
            up.GetComponent<Rigidbody>().isKinematic = false;

            down.GetComponent<Rigidbody>().AddRelativeForce(Random.Range(50, 100), Random.Range(50, 100), 0);
            up.GetComponent<Rigidbody>().AddRelativeForce(-Random.Range(50, 100), -Random.Range(50, 100), 0);

            Score.score += 10;
            SetScoreText();
        }

        if(other.tag == "watermelon")
        {   
            GameManager.instance.audioManager.Play(1, "FruitCut", false);
            up = other.gameObject.transform.GetChild(0).gameObject;
            down = other.gameObject.transform.GetChild(1).gameObject;

            down.transform.parent = null;
            up.transform.parent = null;
            GameObject.Destroy(other.gameObject);

            down.GetComponent<Rigidbody>().isKinematic = false;
            up.GetComponent<Rigidbody>().isKinematic = false;

            down.GetComponent<Rigidbody>().AddRelativeForce(Random.Range(50, 100), Random.Range(50, 100), 0);
            up.GetComponent<Rigidbody>().AddRelativeForce(-Random.Range(50, 100), -Random.Range(50, 100), 0);

            Score.score += 1;
            SetScoreText();
        }

        if(other.tag == "bomb")
        {
            Application.LoadLevel("GameOver");
        }
    }

    void SetScoreText()
    {
        scoreText.text = "SCORE: " + Score.score.ToString();
    }
}

