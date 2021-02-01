using System;
using UnityEngine;

public class MathfRepeat : MonoBehaviour
{
    [SerializeField] private GameObject _prototype;
    
    private void Update()
    {
        var position = new Vector3(Time.time, Mathf.Repeat(-Time.time, 3.0f), 0);
        Instantiate(_prototype, position,Quaternion.identity);
        Debug.Log($"{Mathf.Repeat(Time.time, -10)} - {Time.time%3.0f}");    
    }
}