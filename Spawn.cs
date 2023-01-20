using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] public int WaveSize;
    [SerializeField] public GameObject EnemyPrefab;
    [SerializeField] public float EnemyInterval;
    [SerializeField] public Transform spawnPoint;
    [SerializeField] public float startTime;
    [SerializeField] public Transform[] WayPoints;
    [SerializeField] int enemyCount = 0;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", startTime, EnemyInterval);
    }

    void Update()
    {
        if(enemyCount == WaveSize)
        {
            CancelInvoke("SpawnEnemy");
        }
    }

    void SpawnEnemy() 
    {
        enemyCount++;
        GameObject Enemy = GameObject.Instantiate(EnemyPrefab, spawnPoint.position, Quaternion.identity) as GameObject;
        Enemy.GetComponent<Move>().WayPoints = WayPoints;
    }
}
