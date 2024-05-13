using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "StatisticComponent", menuName = "ScriptableObject/Stats")]
public class StatisticComponent: ScriptableObject
{
    [Header("Setting - Default")]
    [Space]

    [SerializeField] private int _maxHeatlh = 3;

    [SerializeField] private float _moveSpeed = 10;

    [SerializeField] private int _damage = 1;

    [Header("Setting - Speciaial Heart")]
    [Space]

    [SerializeField] private int _protectionHeart = 1;
    [SerializeField] private float _protectionTime = 1;

    // Read-only values

    public int MaxHealth => Mathf.Abs(_maxHeatlh);
    public float MoveSpeed => Mathf.Abs(_moveSpeed);
    public int Damage => Mathf.Abs(_damage);
    public int ProtectionHeart => Mathf.Abs(_protectionHeart);
    public float ProtectionTime => Mathf.Abs(_protectionTime);
}