using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathController : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            var sceneManager = SceneManager.Instance;
            if (sceneManager != null)
            {
                sceneManager.Restart();
            }
        }
    }
}
