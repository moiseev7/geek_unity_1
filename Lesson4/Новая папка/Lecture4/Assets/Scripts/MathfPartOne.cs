using UnityEngine;

public class MathfPartOne : MonoBehaviour
{
    [Header("Angles")]
    [SerializeField] private float _degAngle = 30;
    
    [Header("Abs")]
    [Range(-100,-1)]
    [SerializeField] private float _negativeFloat = -10;

    [Header("Pow")] [SerializeField] private float _base = 5;
    [SerializeField] private float _exp = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Градусы: {_degAngle}; радианы: {Mathf.Deg2Rad * _degAngle}");
        Debug.Log($"Число пи: {Mathf.PI}");
        Debug.Log($"Модуль числа {_negativeFloat} это {Mathf.Abs(_negativeFloat)}");
        Debug.Log($"Синус угла {_degAngle} градусов равен {Mathf.Sin(Mathf.Deg2Rad * _degAngle)}");
        Debug.Log($"{_base} в степени {_exp} равно {Mathf.Pow(_base,_exp)}");
    }
}
