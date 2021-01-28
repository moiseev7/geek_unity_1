using System;
using UnityEngine;

public class MathfRepeat : MonoBehaviour
{
    [SerializeField] private GameObject _prototype;
    
    private void Update()
    {
        Instantiate(_prototype, new Vector3(Time.time, Mathf.Repeat(Time.time, 3.0f), 0),Quaternion.identity);
        Debug.Log($"{Mathf.Repeat(Time.time, 3.0f)} - {Time.time%3.0f}");    
    }
}