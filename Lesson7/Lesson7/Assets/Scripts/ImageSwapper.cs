using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageSwapper : MonoBehaviour
{
    [SerializeField] private List<Sprite> _sprites;
    [SerializeField] private Image _image;
    private int _index = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _index = ++_index % _sprites.Count;

            _image.sprite = _sprites[_index];
        }
    }
}
