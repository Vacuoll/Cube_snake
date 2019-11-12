using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeButton : MonoBehaviour
{
    private bool IsOpen = false;
    public GameObject targetPosition;
    public GameObject movingBorder;
    public float speed;


    void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("CubeMain") && IsOpen==false)
        {
            IsOpen = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.1f, transform.position.z);
        }
    }

    void Update()
    {
        if(IsOpen)
        {
            movingBorder.transform.position = Vector3.MoveTowards(movingBorder.transform.position, targetPosition.transform.position, speed * Time.deltaTime);
        }
    }
}
