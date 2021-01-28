using System;
using UnityEngine;

public class MathfPartTwo : MonoBehaviour
{
    private void Update()
    {
        Debug.Log($"{Mathf.Repeat(Time.time, 3.0f)} - {Time.time%3.0f}");    
    }
}