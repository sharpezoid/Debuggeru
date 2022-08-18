using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    public List<Waypoint> nextWaypoints = new List<Waypoint>();

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position, 0.5f);

        for(int i = 0; i < nextWaypoints.Count; i++)
        {
            Gizmos.DrawLine(transform.position, nextWaypoints[i].transform.position);
        }
    }

    public Waypoint GetRandomNextWaypoint()
    {
        return nextWaypoints[Random.Range(0, nextWaypoints.Count)];
    }
}
