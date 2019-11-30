using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private float seeDistance;

    private float speed;
  
    private CubeMovement target;
    private int difficulty;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("CubeMain").GetComponent<CubeMovement>();
        difficulty = PlayerPrefs.GetInt("Diff");
        if (difficulty == 0)
        {
            speed = 2f;
            seeDistance = 5f;
        }
        else if (difficulty == 1)
        {
            speed = 3f;
            seeDistance = 6f;
        }
        else if (difficulty == 2)
        {
            speed = 4f;
            seeDistance = 7f;
        }
    }

    void Update()
    {
            if (Vector3.Distance(transform.position, target.transform.position) < seeDistance)
            {
                {
                    transform.LookAt(target.transform.position);
                    transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));

                }
            }
        
    }
}
