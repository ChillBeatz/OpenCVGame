using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    // Start is called before the first frame update
    Collider collider;
    Vector3 vect;
    GameObject up, down;

    void Start()
    {
        collider = gameObject.GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetMouseButton(0))
        {
            vect = Input.mousePosition;
            vect.z = 10;
            gameObject.transform.position = Camera.main.ScreenToWorldPoint(vect);
        }
        
        
        if(Input.GetMouseButtonDown(0))
        {
            collider.enabled = true;
        }

        if(Input.GetMouseButtonUp(0))
        {
            collider.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {   
        if(other.tag == "Box")
        {
            down = other.gameObject.transform.GetChild(0).gameObject;
            up = other.gameObject.transform.GetChild(1).gameObject;

            down.transform.parent = null;
            up.transform.parent = null;
            GameObject.Destroy(other.gameObject);

            down.GetComponent<Rigidbody>().isKinematic = false;
            up.GetComponent<Rigidbody>().isKinematic = false;

            down.GetComponent<Rigidbody>().AddRelativeForce(0, Random.Range(80, 100), 0);
            up.GetComponent<Rigidbody>().AddRelativeForce(0, -Random.Range(80, 100), 0);
        }
    }
}
