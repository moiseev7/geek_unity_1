using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutinesOne : MonoBehaviour
{
    [SerializeField] private Renderer _renderer;
    [SerializeField] private Color _color;
    [SerializeField] private CoroutineReturn _coroutineReturn;
    private Material _material;
    
    // Start is called before the first frame update
    void Start()
    {
        _material = _renderer.material;
        StartCoroutine(ChangeColor(_color));
    }

    private IEnumerator  ChangeColor(Color newColor)
    {
        while (_material.color != newColor)
        {
            
            _material.color = Color.Lerp(_material.color, newColor, Time.deltaTime);
            Debug.Log(_material.color);
            switch (_coroutineReturn)
            {
                case CoroutineReturn.Null:
                    yield return null;
                    break;
                case CoroutineReturn.WaitForFixedUpdate:
                    yield return new WaitForFixedUpdate();
                    break;
                case CoroutineReturn.WaitForEndOfFrame:
                    yield return new WaitForEndOfFrame();
                    break;
                case CoroutineReturn.WaitForSecond:
                    yield return new WaitForSeconds(0.1f);
                    break;
                default:
                    yield return null;
                    break;
            }
        }

    }

    private void OnDestroy()
    {
        if(_material!=null)
            Destroy(_material);
        
        
    }
}