using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = System.Random;

public class Spawn : MonoBehaviour
{
    private float _delayToSpawn = 2.00f;
    private float _startTimer = 2.00f;
    private int _spawnDistanceX;
    private int _spawnDistanceY;
    private int _maxDistanceX = 10;
    private int _minDistanceX = -10;
    private int _maxDistanceY = 4;
    private int _minDistanceY = -4;
    private int _maxSetDirection = 3;
    
    public GameObject EnemyObj;
    public Move _enemyMove;
    
    public void Update()
    {
        Random rand = new Random();
        _delayToSpawn -= Time.deltaTime;
        
        if (_delayToSpawn <= 0)
        {
            _spawnDistanceX = rand.Next(_minDistanceX, _maxDistanceX + 1);
            _spawnDistanceY = rand.Next(_minDistanceY, _maxDistanceY + 1);
            
             Instantiate(EnemyObj, new Vector3(_spawnDistanceX, _spawnDistanceY, 0), Quaternion.identity);
             _enemyMove.SetMoveDirection(rand.Next(_maxSetDirection + 1));
            _delayToSpawn = _startTimer;
        }
    }
}
