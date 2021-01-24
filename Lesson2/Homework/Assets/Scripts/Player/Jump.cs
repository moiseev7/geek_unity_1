using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Jump : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _jumpSpeed = 10;

    private bool _isInJump = false;
    
    private void Update()
    {
        if(_rigidbody==null)
            return;

        if(_isInJump)
            return;
        
        if (Input.GetButtonDown("Jump"))
        {
            _rigidbody.velocity +=Vector3.up * _jumpSpeed;
            _isInJump = true;
        }
    }

    private void FixedUpdate()
    {
        if(_rigidbody==null)
            return;
    
        if(!_isInJump)
            return;

        if (_rigidbody.velocity.y <= 0 && _rigidbody.transform.position.y <= 0.01f)
        {
            _isInJump = false;
        }
    }
}
