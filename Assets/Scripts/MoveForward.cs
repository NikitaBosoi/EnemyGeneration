using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float _movingSpeed;

    private void Update()
    {
        transform.Translate(_movingSpeed * Time.deltaTime, 0, 0);
    }
}