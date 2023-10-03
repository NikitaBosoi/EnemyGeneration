using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;

    public void Update()
    {
        transform.Rotate(Vector3.right, _rotationSpeed * Time.deltaTime);
    }
}
