using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] public GameObject BloodPrefab;
    [SerializeField] public float lifetime = 3;

    void Awake()
    {
        Destroy(gameObject, lifetime);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Head"))
        {
            Enemy.damage += 5;

            foreach (Transform child in transform)
            {
                var Blood = Instantiate(BloodPrefab, child.position, child.rotation);
            }
            
            Destroy(gameObject);
        }

        if (collision.CompareTag("Body"))
        {
            Enemy.damage += 2;

            foreach (Transform child in transform)
            {
                var Blood = Instantiate(BloodPrefab, child.position, child.rotation);
            }
            
            Destroy(gameObject);
        }
    }
}
