using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{

void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("CubeMain"))
        {
            other.GetComponent<CubeMovement>().AddTail();
            Destroy(gameObject);
        }
    }
}
