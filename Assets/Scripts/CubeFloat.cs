using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFloat : MonoBehaviour
{
    private float speed = 0.5f;
    private float tilt = 0.5f;
    private Vector3 target;

    private Vector3 startPos = new Vector3(0, 0.5f, -9f);
    private Vector3 endPos = new Vector3(0, 1.5f, -9f);

    void Start()
    {
        target = transform.position;
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        if (transform.position == target && target.y != startPos.y)
            target.y = startPos.y;
        else
            if (transform.position == target && target.y == startPos.y)
            target.y = endPos.y;

        transform.Rotate(Vector3.up * tilt);
    }
}
