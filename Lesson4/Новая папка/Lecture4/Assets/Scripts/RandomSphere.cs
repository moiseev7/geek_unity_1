using UnityEngine;

public class RandomSphere : MonoBehaviour
{
    [SerializeField] private GameObject _prototype;
    [SerializeField] private float _y = 1;
    [SerializeField] private float _radius  = 10;
    

    // Update is called once per frame
    void Update()
    {
        Instantiate(_prototype, Random.insideUnitSphere * _radius, Quaternion.identity);
    }
}