using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float Speed;
    // скорость движения

    public Transform[] WayPoints;

    int curWayPointIndex = 0;
    // местоназначение

    // Update is called once per frame
    void Update()
    {
        if (curWayPointIndex < WayPoints.Length)
        {
            transform.position = Vector3.MoveTowards(transform.position, WayPoints[curWayPointIndex].position, Time.deltaTime * Speed);

            if (Vector3.Distance(transform.position, WayPoints[curWayPointIndex].position) < 0.5f)
            {
                curWayPointIndex++;
            }
        }
    }
}
