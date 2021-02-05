using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class AgentMove : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _agent;

    [SerializeField] private List<Waypoint> _waypoints;
    private Waypoint _current;

    public List<Waypoint> Waypoints
    {
        get => _waypoints;
        set => _waypoints = value;
    }

    public void SetDestination()
    {
        _current = _waypoints[Random.Range(0, _waypoints.Count)];
        _agent.SetDestination(_current.transform.position);
    }

    private void Update()
    {
        if (_agent.remainingDistance < 1)
        {
            SetDestination();
        }
        
        //_agent.SetDestination(_destination.position);
    }

    private void OnDrawGizmos()
    {
        if(_current==null)
            return;
        
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, _current.transform.position);
    }
}
