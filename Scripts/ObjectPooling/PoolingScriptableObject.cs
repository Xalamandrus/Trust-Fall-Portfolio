using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PoolingSettingsMap", menuName = "ScriptableObject/PoolingObject")]
public class PoolingScriptableObject : ScriptableObject
{
    [Header("Configuration")]
    [Space]

    [SerializeField] private float _offsetY;
    [Space]

    [SerializeField] private float _yDeactivate;

    [Header("PrefabListMap")]
    [Space]

    [SerializeField] private GameObject[] _prefabMapArray;

    [Space]

    [SerializeField] private GameObject _prefabMapEnd;

    // Read-only values

    public float OffsetY => -Mathf.Abs(_offsetY);
    public float YDeactivate => Mathf.Abs(_yDeactivate);
    public GameObject[] PrefabMapArray => _prefabMapArray;
    public GameObject PrefabMapEnd => _prefabMapEnd;
}