using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{
    [SerializeField] private Transform _rootTransform;

    [SerializeField] private float _speed = 1;
    

    private Vector3 _movement;

    private void Update()
    {
        _movement.x = Input.GetAxis("Horizontal");
        _movement.z = Input.GetAxis("Vertical");
        
    }
    
    private void FixedUpdate()
    {
        if(_rootTransform==null)
            return;
        
        //Если вектор движения близок к нулю, то не двигаемся
        if(_movement.magnitude<0.01f)
            return;

        //Поворачиваем объект по направлению движения
        _rootTransform.forward = _movement.normalized;

        var translate = Vector3.forward * (_speed * Time.deltaTime);
        
        _rootTransform.Translate(translate);
        
    }

}
