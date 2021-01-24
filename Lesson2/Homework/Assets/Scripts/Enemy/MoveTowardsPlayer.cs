using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsPlayer : MonoBehaviour
{
    [SerializeField] private Transform _rootTransform;
    
    [SerializeField] private float _speed;
    
    private Transform _player;
    
    // Start is called before the first frame update
    void Start()
    {
        _player = PlayerSingleton.Instance.transform;
    }

    private void FixedUpdate()
    {
        if(_player==null || _rootTransform==null)
            return;

        var speed = (_player.position - transform.position).normalized * (_speed * Time.deltaTime);
        _rootTransform.Translate(speed);
    }

    public void SetSpeed(float speed)
    {
        _speed = speed;
    }
}
