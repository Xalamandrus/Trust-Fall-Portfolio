using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StalactiteEvent : MonoBehaviour
{
    [SerializeField] private GameObject _stalactitePrefab;

    [SerializeField] private Vector2[] _position;

    private void Start()
    {
        StalactiteEventTrigger.OnStalactiteEvent += StalactiteEventStart;
    }

    private void OnDestroy()
    {
        StalactiteEventTrigger.OnStalactiteEvent -= StalactiteEventStart;
    }

    private void StalactiteEventStart()
    {
        int _randomNumber = Random.Range(1, _position.Length + 1);

        List<int> _positionIndex = new List<int>();

        for (int i = 0; i < _position.Length; i++)
        {
            _positionIndex.Add(i);
        }

        for (int i = 0; i < _randomNumber; i++)
        {
            int _randomIndex = Random.Range(0, _positionIndex.Count);
            int _selectedIndex = _positionIndex[_randomIndex];
            _positionIndex.Remove(_randomIndex);

            Instantiate(_stalactitePrefab, _position[_selectedIndex], Quaternion.identity);
        }
    }
}
