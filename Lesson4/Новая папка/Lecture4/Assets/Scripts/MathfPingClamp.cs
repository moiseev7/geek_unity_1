using UnityEngine;

public class MathfPingClamp: MonoBehaviour
{
    [SerializeField] private GameObject _prototype;
    [SerializeField] private float _min = 2;
    [SerializeField] private float _max = 10;
    
    private void Update()
    {
        Instantiate(_prototype, new Vector3(Time.time, Mathf.Clamp(Time.time,_min,_max), 0),Quaternion.identity);
        //Debug.Log($"{Mathf.PingPong(Time.time, 3.0f)}");    
    }
}