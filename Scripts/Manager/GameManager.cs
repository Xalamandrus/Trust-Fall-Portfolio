using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{
    [Range(0f, 30f)]
    [SerializeField] private float _moveSpeedY;

    public float MoveSpeedY
    {
        get { return _moveSpeedY; }
        set { _moveSpeedY = value; }
    }
}