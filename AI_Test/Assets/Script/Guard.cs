using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GuardStates
{
    Patrolling, Waiting, Chasing
}

public class Guard : MonoBehaviour
{
    public GuardStates states;

    public List<GameObject> wayPoints;
    public int wayPointIndex;

    public float patrolSpeed;

    public float maxDuration = 5f;
    public float durationDepletion = 1;
    public float durationRegen = 0.5f;

    private void Update()
    {
        switch (states)
        {
            case GuardStates.Patrolling:
                Patrol();
                break;
            case GuardStates.Waiting:
                Wait();
                break;
            case GuardStates.Chasing:
                Chase();
                break;
        }
    }

    // States
    void Patrol()
    {
        // move toward the current waypoint
        // deplete patrol duration over time
        
        MoveTowardWaypoint();
    }

    void Wait()
    {
        
    }

    void Chase()
    {
        
    }
    
    // State Functionalities

    void MoveTowardWaypoint()
    {
        transform.position = Vector3.MoveTowards(transform.position, wayPoints[wayPointIndex].transform.position, patrolSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == wayPoints[wayPointIndex]);
        {
            wayPointIndex = (wayPointIndex + 1) % wayPoints.Count;
        }
    }
}
