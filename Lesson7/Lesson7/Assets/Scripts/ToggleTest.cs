using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleTest : MonoBehaviour
{
    public void SetToggle(bool toggle)
    {
        var text = toggle ? "on" : "off";
        Debug.Log($"Toggle is {text}");
    }
}
