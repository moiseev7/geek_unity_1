using System.Collections;
using UnityEngine;

public class CoroutinesTwo : MonoBehaviour
{
    [SerializeField] private Renderer _renderer;
    [SerializeField] private Color _color;
    private Material _material;
    private Coroutine _coroutine;
    private WaitForSeconds _waitTime = new WaitForSeconds(0.1f);
    
    // Start is called before the first frame update
    void Start()
    {
        _material = _renderer.material;
        _coroutine = StartCoroutine(ChangeColor(_color));
    }

    private IEnumerator  ChangeColor(Color newColor)
    {
        while (_material.color != newColor)
        {
            
            _material.color = Color.Lerp(_material.color, newColor, Time.deltaTime);
            Debug.Log(_material.color);
            yield return _waitTime;
        }

    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StopCoroutine(_coroutine);
        }
    }

    

    private void OnDestroy()
    {
        if(_material!=null)
            Destroy(_material);
        
        
    }
}