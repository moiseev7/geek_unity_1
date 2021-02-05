using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;

    [SerializeField] private float _speed = 1;
    

    private Vector3 _movement;

    private void Update()
    {
        _movement.x = Input.GetAxis("Horizontal");
        _movement.z = Input.GetAxis("Vertical");
        
    }
    
    private void FixedUpdate()
    {
        if(_rigidbody==null)
            return;
        
        //Если вектор движения близок к нулю, то не двигаемся
        if (_movement.magnitude < 0.01f)
        {
            //_rigidbody.velocity = Vector3.zero;
            return;
        }

        //Поворачиваем объект по направлению движения
        _rigidbody.transform.forward = _movement.normalized;

        var velocity = _rigidbody.transform.forward * (_speed * Time.deltaTime);

        _rigidbody.velocity = velocity;

    }

}