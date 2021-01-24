using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private GameObject _target;

    [SerializeField] private float _period = 5;
    private float _lastTime = 0;

    private void Update()
    {
        if(_target==null)
            return;
        
        
        if (Time.time - _lastTime > _period)
        {
            _lastTime = Time.time;
            _target.SetActive(!_target.activeSelf);
        }
    }
}
