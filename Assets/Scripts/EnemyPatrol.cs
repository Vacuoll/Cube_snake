using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    private float speed;
    private float waitTime;
    public float startWaitTime;

    public Transform[] moveSpots;
    private int randomSpot;
    private int difficulty;

    void Start()
    {
        waitTime = startWaitTime;
        randomSpot = Random.Range(0, moveSpots.Length - 1);
        difficulty = PlayerPrefs.GetInt("Diff");
        if (difficulty == 0)
        {
            speed = 3f;
        }
        else if (difficulty == 1)
        {
            speed = 4f;
        }
        else if (difficulty == 2)
        {
            speed = 5f;
        }
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, moveSpots[randomSpot].position, speed * Time.deltaTime);
        if(Vector3.Distance(transform.position, moveSpots[randomSpot].position) < 0.1f)
        {
            if(waitTime <= 0)
            {
                randomSpot = Random.Range(0, moveSpots.Length);
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }
}
