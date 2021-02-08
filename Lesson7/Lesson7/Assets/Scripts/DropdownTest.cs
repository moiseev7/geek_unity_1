using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownTest : MonoBehaviour
{
    [SerializeField] private Dropdown _dropdown;
    
    public void SetDropDown(int index)
    {
        
        Debug.Log($"Drop down value is : {_dropdown.options[index].text}");
    }
}
