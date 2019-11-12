using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TailMovement : MonoBehaviour
{

    public float speed;
    public int index;

    private Vector3 tailTarget;
    public GameObject tailTargetObj;
    private CubeMovement mainCube;
    void Start()
    {
        mainCube = GameObject.FindGameObjectWithTag("CubeMain").GetComponent<CubeMovement>();
        speed = mainCube.speed + 3;
        tailTargetObj = mainCube.tailObjects[mainCube.tailObjects.Count - 2];
        index = mainCube.tailObjects.IndexOf(gameObject);
        
    }


    void Update()
    {
        tailTarget = tailTargetObj.transform.position;
        
        transform.LookAt(tailTarget);
        transform.position = Vector3.Lerp(transform.position, tailTarget, Time.deltaTime * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("CubeMain"))
        {
            if(index > 3)
            {
                mainCube.Lose();
            }
        }
    }
}

