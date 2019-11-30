using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Borders : MonoBehaviour
{
    private CubeMovement mainCube;

    void Start()
    {
        mainCube = GameObject.FindGameObjectWithTag("CubeMain").GetComponent<CubeMovement>();
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CubeMain") || other.CompareTag("CubePlus"))
        {
            mainCube.Lose();
        }
        else
        if(other.CompareTag("Enemy"))
        {
            Destroy(other);
        }
    }
}
