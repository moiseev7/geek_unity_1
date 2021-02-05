using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SimpleAgent : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _agent;
    [SerializeField] private Transform _target;
    
    // Start is called before the first frame update
    void Start()
    {
        _agent.SetDestination(_target.position);
    }

}
