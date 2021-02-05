using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private AgentMove _agent;
    [SerializeField] private List<Waypoint> _waypoints;

    [SerializeField] private float _period = 3;

    private float _lastTime = 0;

    private void Update()
    {
        if(Time.time<_lastTime+_period)
            return;

        _lastTime = Time.time;

        var agent = Instantiate(_agent, transform.position, Quaternion.identity);
        agent.Waypoints = _waypoints;
        agent.SetDestination();
    }
}