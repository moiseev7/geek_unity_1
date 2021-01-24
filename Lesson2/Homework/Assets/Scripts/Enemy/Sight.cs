using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sight : MonoBehaviour
{
    [SerializeField] private Transform _rootTransform;
    [SerializeField]
    MoveTowardsPlayer _moveTowardsPlayer;
    
    [SerializeField] private float _speed;
    [SerializeField] private float _sightDistance = 10;

    private bool _hasFoundPlayer = false;
    
    private Transform _player;
    
    // Start is called before the first frame update
    void Start()
    {
        _player = PlayerSingleton.Instance.transform;
    }

    private void Update()
    {
        if(_hasFoundPlayer)
            return;
        
        if(_player==null || _moveTowardsPlayer == null || _rootTransform==null)
            return;

        if (Vector3.Distance(_rootTransform.position, _player.position) < _sightDistance)
        {
            _hasFoundPlayer = true;
            _moveTowardsPlayer.SetSpeed(_speed);
        }
        
    }
}
