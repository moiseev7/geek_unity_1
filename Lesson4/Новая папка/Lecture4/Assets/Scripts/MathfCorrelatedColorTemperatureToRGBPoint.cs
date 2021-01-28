using System;
using UnityEngine;

public class MathfCorrelatedColorTemperatureToRGBPoint : MonoBehaviour
{
    [SerializeField] private Renderer _renderer;

    private MaterialPropertyBlock _propBlock;

    private void Awake()
    {
        _propBlock = new MaterialPropertyBlock();
    }

    public void SetColor(Color color)
    {
        _renderer.GetPropertyBlock(_propBlock);
        _propBlock.SetColor("_Color", color);
        _renderer.SetPropertyBlock(_propBlock);
    }
}