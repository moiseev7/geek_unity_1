using UnityEngine;

public class RandomValue : MonoBehaviour
{
    [SerializeField] private GameObject _prototype;
    [SerializeField] private float _y = 1;
    [SerializeField] private float _value  = 10;
    

    // Update is called once per frame
    void Update()
    {
        Instantiate(_prototype, new Vector3(Random.value * _value, _y, Random.value * _value), Quaternion.identity);
    }
}