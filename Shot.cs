using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Shot : MonoBehaviour
{
    private bool touche;
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    private float timeBetweenShots;
    public float timeStartShots;

    public void Fire()
    {
        touche = true;
    }

    public void NoFire()
    {
        touche = false;
    }

    public void FixedUpdate ()
    {
        if (touche == true)
        {
            if (timeBetweenShots <= 0)
            {
                var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
                bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
                timeBetweenShots = timeStartShots;
            }
            else
            {
                timeBetweenShots -= Time.deltaTime;
            }
        }
    }
}