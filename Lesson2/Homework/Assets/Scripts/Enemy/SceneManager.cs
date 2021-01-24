using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    public static SceneManager Instance;
    
    private void Awake()
    {
        Instance = this;
    }

    public void Restart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene( UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex ) ;
    }

    private void OnDestroy()
    {
        if (Instance == this)
            Instance = null;
    }
}
