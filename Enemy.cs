using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static int damage;
    [SerializeField] public int HP;
    [SerializeField] public GameObject Character;

    private void OnTriggerEnter(Collider collision)
    {
        if (damage >= HP)
        {
            Character.GetComponent<Animator>().enabled = false;
            KillEnemy();
            Character.GetComponent<BoxCollider>().enabled = false;
            damage = 0;
            }
        }

        void KillEnemy()
        {
            Character.GetComponent<Move>().Speed = 0;

            foreach (Transform child in transform)
            {
                child.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
                child.GetComponent<Rigidbody>().useGravity = true;
                child.transform.gameObject.tag = "Obstacle";
            }
        }
 }
