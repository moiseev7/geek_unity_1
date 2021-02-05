using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAnimation : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Animator _animator;

    private void FixedUpdate()
    {
        _animator.SetBool("move", _rigidbody.velocity.magnitude>0.01f);
    }
}