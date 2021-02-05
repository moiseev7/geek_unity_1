using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logger : MonoBehaviour
{
    public void Log(float value)
    {
        Debug.Log($"Value: {value}");
    }
}
