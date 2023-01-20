using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] public GameObject BloodPrefab;
    [SerializeField] public Transform BloodSpawnPoint;
    [SerializeField] public float lifetime = 3;

    void Awake()
    {
        Destroy(gameObject, lifetime);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Head"))
        {
            Enemy.health += 5;
            var Blood = Instantiate(BloodPrefab, BloodSpawnPoint.position, BloodSpawnPoint.rotation);
            Blood = Instantiate(BloodPrefab, BloodSpawnPoint.position, BloodSpawnPoint.rotation);
            Blood = Instantiate(BloodPrefab, BloodSpawnPoint.position, BloodSpawnPoint.rotation);
            Blood = Instantiate(BloodPrefab, BloodSpawnPoint.position, BloodSpawnPoint.rotation);
        }

        if (collision.CompareTag("Body"))
        {
            Enemy.health += 2;
            var Blood = Instantiate(BloodPrefab, BloodSpawnPoint.position, BloodSpawnPoint.rotation);
            Blood = Instantiate(BloodPrefab, BloodSpawnPoint.position, BloodSpawnPoint.rotation);
        }

    }
}
