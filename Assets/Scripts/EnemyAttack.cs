using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private float seeDistance = 5f;

    private float speed = 2;
  
    public GameObject target;

    void Update()
    {
            if (Vector3.Distance(transform.position, target.transform.position) < seeDistance)
            {
                {
                    transform.LookAt(target.transform.position);
                    //transform.position = Vector3.Lerp(transform.position, target.transform.position, Time.deltaTime * speed);
                    transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));

                }
            }
        
    }
}
