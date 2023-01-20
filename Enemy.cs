using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static int health;
    [SerializeField] public int HP;
    [SerializeField] public GameObject Character;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            Debug.Log(health);
        }

        if (health >= HP)
        {
            health = 0;
            Debug.Log(health);
            KillEnemy();
            health = 0;
        }
    }

    void KillEnemy()
    {

        Character.GetComponent<Move>().Speed = 0;
        Character.GetComponent<BoxCollider>().enabled = false;

        foreach (Transform child in transform)
        {
            child.GetComponent<Rigidbody>().useGravity = true;
            child.GetComponent<BoxCollider>().isTrigger = false;
            child.transform.gameObject.tag = "Obstacle";
        }
    }
}
