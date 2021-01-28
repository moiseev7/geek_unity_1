using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathfLerp : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Transform _min;
    [SerializeField] private Transform _max;
    [Range(0,1)]
    [SerializeField] private float _lerp;

    private void Update()
    {
        var max = _max.position;
        var min = _min.position;
        float x = Mathf.Lerp(min.x, max.x,_lerp);
        float y = Mathf.Lerp(min.y, max.y,_lerp);
        float z = Mathf.Lerp(min.z, max.z,_lerp);
        _target.transform.position = new Vector3(x,y,z);
    }
}