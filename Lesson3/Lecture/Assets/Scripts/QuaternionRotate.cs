using UnityEngine;

public class QuaternionRotate : MonoBehaviour
{
    [SerializeField] private float _speed = 5;
    
    [SerializeField] private Transform _local;
    [SerializeField] private Transform _world;
    
    // Start is called before the first frame update
    void Update()
    {
        if(_local==null || _world==null)
            return;
        
        _local.Rotate(Vector3.up * Time.deltaTime * _speed);
        _world.Rotate(Vector3.up * Time.deltaTime * _speed,Space.World);
    }

}