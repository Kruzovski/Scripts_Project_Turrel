using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public int WaveSize;
    //������ ����� ������ �������� � �����

    public GameObject EnemyPrefab;
    //��� ������ ������� (����� � �����)

    public float EnemyInterval;
    //��������� �������� ������ �������

    public Transform spawnPoint;
    //����� ����� ������ � �����

    public float startTime;
    //����� �������, ����� ������� � ������ ������ ������� ������ � �����

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
