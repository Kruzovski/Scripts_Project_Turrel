using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static int health;
    public int HP;
    public GameObject Character;
    public GameObject Head;
    public GameObject BodyPrefab;
    public GameObject ButtPrefab;
    public GameObject LeftArm1Prefab;
    public GameObject LeftArm2Prefab;
    public GameObject RightArm1Prefab;
    public GameObject RightArm2Prefab;
    public GameObject LeftLeg1Prefab;
    public GameObject LeftLeg2Prefab;
    public GameObject RightLeg1Prefab;
    public GameObject RightLeg2Prefab;

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

        Head.GetComponent<Rigidbody>().useGravity = true;
        Head.GetComponent<BoxCollider>().isTrigger = false;
        Head.transform.gameObject.tag = "Obstacle";

        BodyPrefab.GetComponent<Rigidbody>().useGravity = true;
        BodyPrefab.GetComponent<BoxCollider>().isTrigger = false;
        BodyPrefab.transform.gameObject.tag = "Obstacle";

        ButtPrefab.GetComponent<Rigidbody>().useGravity = true;
        ButtPrefab.GetComponent<BoxCollider>().isTrigger = false;
        ButtPrefab.transform.gameObject.tag = "Obstacle";

        LeftArm1Prefab.GetComponent<Rigidbody>().useGravity = true;
        LeftArm1Prefab.GetComponent<BoxCollider>().isTrigger = false;
        LeftArm1Prefab.transform.gameObject.tag = "Obstacle";

        LeftArm2Prefab.GetComponent<Rigidbody>().useGravity = true;
        LeftArm2Prefab.GetComponent<BoxCollider>().isTrigger = false;
        LeftArm2Prefab.transform.gameObject.tag = "Obstacle";

        RightArm1Prefab.GetComponent<Rigidbody>().useGravity = true;
        RightArm1Prefab.GetComponent<BoxCollider>().isTrigger = false;
        RightArm1Prefab.transform.gameObject.tag = "Obstacle";

        RightArm2Prefab.GetComponent<Rigidbody>().useGravity = true;
        RightArm2Prefab.GetComponent<BoxCollider>().isTrigger = false;
        RightArm2Prefab.transform.gameObject.tag = "Obstacle";

        LeftLeg1Prefab.GetComponent<Rigidbody>().useGravity = true;
        LeftLeg1Prefab.GetComponent<BoxCollider>().isTrigger = false;
        LeftLeg1Prefab.transform.gameObject.tag = "Obstacle";

        LeftLeg2Prefab.GetComponent<Rigidbody>().useGravity = true;
        LeftLeg2Prefab.GetComponent<BoxCollider>().isTrigger = false;
        LeftLeg2Prefab.transform.gameObject.tag = "Obstacle";

        RightLeg1Prefab.GetComponent<Rigidbody>().useGravity = true;
        RightLeg1Prefab.GetComponent<BoxCollider>().isTrigger = false;
        RightLeg1Prefab.transform.gameObject.tag = "Obstacle";

        RightLeg2Prefab.GetComponent<Rigidbody>().useGravity = true;
        RightLeg2Prefab.GetComponent<BoxCollider>().isTrigger = false;
        RightLeg2Prefab.transform.gameObject.tag = "Obstacle";


    }
}
