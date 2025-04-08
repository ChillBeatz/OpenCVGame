using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl1 : MonoBehaviour
{
    public Transform Apple;
    float offsetZ = 5f, offsetY = 1f;
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.identity;
        Vector3 pos = Apple.position;
        pos.z -= offsetZ;
        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
