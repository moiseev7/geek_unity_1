using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Shoot : MonoBehaviour
{
    [SerializeField] private Transform _rootTransform;
    [SerializeField] private Bullet _bullet;
    [SerializeField] Vector3 _offset = new Vector3(0,1,0);
    [SerializeField] private float _shootPeriod = .5f;

    private float _lastShot;
    

    private void Update()
    {
        if(_bullet==null || _rootTransform==null)
            return;
        
        if (Input.GetButtonDown("Fire1"))
        {
            if(Time.time<_lastShot + _shootPeriod)
                return;

            _lastShot = Time.time;
            
            var instance = Instantiate(_bullet, transform.position + _offset, Quaternion.identity);
            instance.SetDirection(_rootTransform.forward);
        }
    }
}
