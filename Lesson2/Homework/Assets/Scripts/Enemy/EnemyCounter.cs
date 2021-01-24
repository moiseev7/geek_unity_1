using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCounter : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private int _goal = 10;
    private int _current = 0;
    
    
    public static EnemyCounter Instance;

    private void Awake()
    {
        Instance = this;
        _text.text = $"{_current}/{_goal}";
    }

    public void RegisterFrag()
    {
        _current++;
        if (_current >= _goal)
        {
            SceneManager.Instance.Restart();
            return;
        }

        _text.text = $"{_current}/{_goal}";
    }
    
}
