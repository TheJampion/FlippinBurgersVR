using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachFoodToObject : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            other.transform.parent = transform;
            Debug.Log("food attached");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            other.transform.parent = null;
            Debug.Log("food detached");
        }
    }
}
