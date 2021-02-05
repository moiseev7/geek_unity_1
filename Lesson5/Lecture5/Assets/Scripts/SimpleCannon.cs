using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCannon : MonoBehaviour
{
    [SerializeField] private Transform _cannon;
    [SerializeField] private Transform _target;

    private void Update()
    {
        var dir = (_target.position - _cannon.position).normalized;

        _cannon.forward = dir;
        
    }
}
