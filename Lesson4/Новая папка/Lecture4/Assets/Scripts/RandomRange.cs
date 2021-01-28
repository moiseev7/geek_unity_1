using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRange : MonoBehaviour
{
    [SerializeField] private GameObject _prototype;
    [SerializeField] private float _y = 0;
    [SerializeField] private float _min = 0;
    [SerializeField] private float _max = 10;

    // Update is called once per frame
    void Update()
    {
        Instantiate(_prototype, new Vector3(Random.Range(_min, _max), _y, Random.Range(_min, _max)), Quaternion.identity);
    }
}