using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyTest : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] Vector3 _vector3 = Vector3.one*10;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ForceMode mode = ForceMode.Impulse;
            _rigidbody.AddForce(_vector3,mode);
        }    
    }
}
