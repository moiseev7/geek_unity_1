﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PhysicsRaycast : MonoBehaviour
{
    [SerializeField] private LayerMask _mask;
    [SerializeField] private Transform _player;
    [SerializeField] private float _distance = 10;
    Color _color = Color.green;
    
    public UnityEvent OnFoundPlayer;
    public UnityEvent OnLostPlayer;
    public bool _foundPlayer;

    private void FixedUpdate()
    {
        RaycastHit hit;

        var startPos = transform.position;
        var dir = _player.position - startPos;


        var rayCast = Physics.Raycast(startPos, dir, out hit, _distance, _mask);

        _color = Color.green;
        var foundPlayerThisFrame = false;
        
        if (rayCast)
        {
            if (hit.collider.gameObject.CompareTag("Player"))
            {
                _color = Color.red;
                foundPlayerThisFrame = true;
            }
        }

        if (foundPlayerThisFrame != _foundPlayer)
        {
            UpdateState(foundPlayerThisFrame);
        }
        
        //Debug.DrawRay(_caster.position, dir, _color);
    }

    private void UpdateState(bool foundPlayerThisFrame)
    {
        _foundPlayer = foundPlayerThisFrame;
        if (_foundPlayer)
        {
            OnFoundPlayer.Invoke();
            Debug.Log("Found player");
            
        }
        else
        {
            OnLostPlayer.Invoke();
            Debug.Log("LostPlayer player");    
        }
        
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = _color;
        
        Gizmos.DrawLine(transform.position, transform.position + (_player.position - transform.position).normalized * _distance);
        
    }
}
    
