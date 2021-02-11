using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnSpace : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _audioSource.Play();
        }
    } 

}
