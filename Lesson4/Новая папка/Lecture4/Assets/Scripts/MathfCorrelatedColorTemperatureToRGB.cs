using UnityEngine;

public class MathfCorrelatedColorTemperatureToRGB : MonoBehaviour
{
    [SerializeField] private MathfCorrelatedColorTemperatureToRGBPoint _prototype;
    [SerializeField] private float _speed = 1;

    private void Update()
    {
        var kelvin = Time.time * _speed;
        var color = Mathf.CorrelatedColorTemperatureToRGB(kelvin);
        Debug.Log($"Kelvin: {kelvin}, color {color}");
        var instance = Instantiate(_prototype, new Vector3(Time.time, 0, 0),Quaternion.identity);
        instance.SetColor(color);
    }
}