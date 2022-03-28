using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTrigger1 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
    Destroy(other.gameObject);
    }
}
