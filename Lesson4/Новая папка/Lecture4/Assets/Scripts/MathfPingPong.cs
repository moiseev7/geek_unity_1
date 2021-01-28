using UnityEngine;

public class MathfPingPong : MonoBehaviour
{
    [SerializeField] private GameObject _prototype;
    
    private void Update()
    {
        Instantiate(_prototype, new Vector3(Time.time, Mathf.PingPong(Time.time, 3.0f), 0),Quaternion.identity);
        Debug.Log($"{Mathf.PingPong(Time.time, 3.0f)}");    
    }
}