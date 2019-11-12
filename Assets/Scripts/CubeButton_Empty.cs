using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeButton_Empty : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("CubeMain"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.1f, transform.position.z);
        }
    }

}
