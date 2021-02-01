using UnityEngine;

public class VectorLerp : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Transform _min;
    [SerializeField] private Transform _max;
    [Range(0,1)]
    [SerializeField] private float _lerp;

    private void Update()
    {
        var max = _max.position;
        var min = _min.position;
        _target.transform.position = Vector3.Lerp(min,max,_lerp);
    }
}