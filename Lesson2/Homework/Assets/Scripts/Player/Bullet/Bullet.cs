using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Vector3 _direction;
    [SerializeField] private float _speed = 10;
    [SerializeField] private Transform _rootTransform;

    public void SetDirection(Vector3 direction)
    {
        _direction = direction.normalized;
    }

    private void FixedUpdate()
    {
        if(_rootTransform==null)
            return;
           
        _rootTransform.Translate(_direction * (Time.deltaTime * _speed));
    }
}
