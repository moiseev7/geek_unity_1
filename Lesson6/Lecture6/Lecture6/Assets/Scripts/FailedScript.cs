using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailedScript : MonoBehaviour
{
    [SerializeField] private bool _fixedUpdate;
    [SerializeField] private bool _update;
    [SerializeField] private bool _lateUpdate;

    private void FixedUpdate()
    {
        if(_fixedUpdate)
            transform.position = Vector3.zero;
    }

    private void Update()
    {
        if(_update)
            transform.position = Vector3.zero;
    }

    private void LateUpdate()
    {
        if(_lateUpdate)
            transform.position = Vector3.zero;
    }
}
