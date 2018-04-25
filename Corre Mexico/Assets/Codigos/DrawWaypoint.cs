using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DrawWaypoint : MonoBehaviour
{

    void OnDrawGizmos()
    {
        Transform[] waypoints = this.GetComponentsInChildren<Transform>();
        foreach (Transform waypoint in waypoints)
            Gizmos.DrawSphere(waypoint.position, 1.0f);
    }
}