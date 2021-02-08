using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SurpiseText : MonoBehaviour
{
    [SerializeField] private Text _text;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _text.text = Random.Range(0, 10000).ToString();
        }
    }
}
