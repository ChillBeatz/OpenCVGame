using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour
{
    void OnTriggerExit(Collider Drop)
    {
        Destroy(Drop.gameObject);
    }
}
