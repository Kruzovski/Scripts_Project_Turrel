using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public int WaveSize;
    //Размер волны спавна монстров В Юнити

    public GameObject EnemyPrefab;
    //Тип спавна монстра (выбор в Юнити)

    public float EnemyInterval;
    //Временной интервал спавна монстра

    public Transform spawnPoint;
    //Выбор точки спавна в Юнити

    public float startTime;
    //Выбор времени, через которое с начала уровня начнётся спавна в Юнити

    public Transform[] WayPoints;

    int enemyCount = 0;

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
