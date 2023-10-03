using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Scaling : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;

    private Vector3 _maxScale = new Vector3(2, 2, 2);
    private Vector3 _minScale = new Vector3(0.1f, 0.1f, 0.1f);
    
    public void Update()
    {
        if(transform.localScale.x < _maxScale.x)
        {
        transform.localScale += new Vector3(_scaleSpeed * Time.deltaTime, _scaleSpeed * Time.deltaTime, _scaleSpeed * Time.deltaTime);
        }
    }
}
