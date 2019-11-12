using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsRotation : MonoBehaviour
{
    public GameObject center;

    // Update is called once per frame
    void FixedUpdate()
    {
        center.transform.Rotate(0, 100 * Time.fixedDeltaTime, 0);
    }
}
