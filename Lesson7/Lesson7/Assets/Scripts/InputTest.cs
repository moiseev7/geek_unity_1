using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputTest : MonoBehaviour
{
    [SerializeField] private InputField _inputField;
    
    public void OnType(string text)
    {
        Debug.Log($"Typing: {text}");
    }
    
    public void OnFinished(string text)
    {
        Debug.Log($"Finished: {text}");
        Debug.Log($"The text was '{_inputField.text}'");
    }
}
