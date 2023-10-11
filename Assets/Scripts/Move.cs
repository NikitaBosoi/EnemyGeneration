using System;
using UnityEngine;
using UnityEngine.EventSystems;
using Random = System.Random;


public class Move : MonoBehaviour
{
    const int XPLUS = 0;
    const int XMINUS = 1;
    const int YPLUS = 2;
    const int YMINUS = 3;
    
    private int _directionX = 0;
    private int _directionY = 1;
    [SerializeField] private float _movingSpeed;
    
    [SerializeField] public int SettedDirection;

    private void Update()
    {
        switch (SettedDirection)
        {
            case XPLUS:
                transform.Translate(_movingSpeed * Time.deltaTime, 0, 0);
                break;
            case XMINUS:
                transform.Translate((-1) * _movingSpeed * Time.deltaTime, 0, 0);
                break;
            case YPLUS:
                transform.Translate( 0,_movingSpeed * Time.deltaTime, 0);
                break;
            case YMINUS:
                transform.Translate(0, (-1) * _movingSpeed * Time.deltaTime, 0);
                break;
        }
    }
    
    public void SetMoveDirection(int Direction)
    {
        SettedDirection = Direction;
    }
}