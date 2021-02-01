using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentMove : MonoBehaviour
{
    [SerializeField] private Transform _destination;
    [SerializeField] private NavMeshAgent _agent;

    private void Update()
    {
        _agent.SetDestination(_destination.position);
    }
}
