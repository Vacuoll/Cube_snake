using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretRoom : MonoBehaviour
{
    public GameObject Cube;
    public float distanse;
    void Update()
    {
        if (Vector3.Distance(transform.position, Cube.transform.position) < distanse)
            gameObject.SetActive(false);
        else
            gameObject.SetActive(true);
    }
}
