using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    public float startTimeBtwStart;//промежуток между падениями блоков
    public GameObject[] XSpawnPosition;

    private float _timeBtwStart = 0;
      
    void Update()
    {
            if (_timeBtwStart <= 0)
            {
                int rand = Random.Range(0, XSpawnPosition.Length);
                Instantiate(enemy, XSpawnPosition[rand].transform.position, Quaternion.identity);
                _timeBtwStart = startTimeBtwStart;
            }
            else
            {
                _timeBtwStart -= Time.deltaTime;
            }
    }
}
