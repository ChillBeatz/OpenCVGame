using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject apple, orange, lemon, watermelon, bomb;
    GameObject appleCP, orangeCP, lemonCP, watermelonCP, bombCP;
    int level = 4;

    void Start()
    {
        
    }

    float n;
    // Update is called once per frame
    void Update()
    {
        n = n + Time.deltaTime;
        if(Score.score >= 100)
        {
            level = 2;
        }
        if (n > Random.Range(level, 5))
        {   
            for(int i = 0;i < Random.Range(3,7);i++)
            {
                switch (Random.Range(0,5))
                {
                    case 0: copyWatermelon();break;
                    case 1: copyApple();break;
                    case 2: copyOrange();break;
                    case 3: copyLemon();break;
                    case 4: copyBomb();break;
                }
            }

            n = 0;
        }
    }

    //Apple
    void copyApple()
    {       
        appleCP = GameObject.Instantiate(apple);
        appleCP.transform.position = new Vector3(Random.Range(-7, 7f), -6, 0);
        appleCP.SetActive(true);

        Rigidbody Arig;
        Arig = appleCP.GetComponent<Rigidbody>();
        Arig.AddForce(Random.Range(-100, 100), Random.Range(500, 750), 0);
        Arig.AddTorque(Random.Range(-50, 50), Random.Range(-50, 50), Random.Range(-50, 50));
    }

    //Orange
    void copyOrange()
    {
        orangeCP = GameObject.Instantiate(orange);
        orangeCP.transform.position = new Vector3(Random.Range(-7, 7f), -6, 0);
        orangeCP.SetActive(true);

        Rigidbody Orig;
        Orig = orangeCP.GetComponent<Rigidbody>();
        Orig.AddForce(Random.Range(-100, 100), Random.Range(500, 750), 0);
        Orig.AddTorque(Random.Range(-50, 50), Random.Range(-50, 50), Random.Range(-50, 50));
    }

    //Lemon
    void copyLemon()
    {
        lemonCP = GameObject.Instantiate(lemon);
        lemonCP.transform.position = new Vector3(Random.Range(-7, 7f), -6, 0);
        lemonCP.SetActive(true);

        Rigidbody lrig;
        lrig = lemonCP.GetComponent<Rigidbody>();
        lrig.AddForce(Random.Range(-100, 100), Random.Range(500, 750), 0);
        lrig.AddTorque(Random.Range(-50, 50), Random.Range(-50, 50), Random.Range(-50, 50));
    }

    //Watermelon
    void copyWatermelon()
    {
        watermelonCP = GameObject.Instantiate(watermelon);
        watermelonCP.transform.position = new Vector3(Random.Range(-7, 7f), -6, 0);
        watermelonCP.SetActive(true);

        Rigidbody wrig;
        wrig = watermelonCP.GetComponent<Rigidbody>();
        wrig.AddForce(Random.Range(-100, 100), Random.Range(500, 750), 0);
        wrig.AddTorque(Random.Range(-50, 50), Random.Range(-50, 50), Random.Range(-50, 50));
    }

    //Bomb
    void copyBomb()
    {
        bombCP = GameObject.Instantiate(bomb);
        bombCP.transform.position = new Vector3(Random.Range(-7, 7f), -6, 0);
        bombCP.SetActive(true);

        Rigidbody brig;
        brig = bombCP.GetComponent<Rigidbody>();
        brig.AddForce(Random.Range(-100, 100), Random.Range(500, 750), 0);
        brig.AddTorque(Random.Range(-50, 50), Random.Range(-50, 50), Random.Range(-50, 50));
    }
}