using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBox : MonoBehaviour
{   
    // Start is called before the first frame update
    public GameObject boxbox;
    GameObject objcopy;

    void Start()
    {
        
    }

    // Update is called once per frame
    float t;

    void Update()
    {
        t = t + Time.deltaTime;

        if(t > Random.Range(1f, 2))
        {
            createcopy();
            t = 0;
        }
    }

    void createcopy()
    {
        objcopy = GameObject.Instantiate(boxbox);
        objcopy.transform.position = new Vector3(Random.Range(-6, 6f), -5, 0);
        objcopy.SetActive(true);

        Rigidbody rig;
        rig = objcopy.GetComponent<Rigidbody>();
        rig.AddForce(Random.Range(-200, 200), Random.Range(700, 750), 0);
        rig.AddTorque(Random.Range(-50, 50), Random.Range(-50, 50), Random.Range(-50, 50));
    }
}
