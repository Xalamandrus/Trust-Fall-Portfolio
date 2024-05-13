using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] GameObject[] _hearts;
    private int _numOfHearts;

    [Space]

    [SerializeField] GameObject[] _specialHearts;
    private int _numOfspecialHearts;

    private void Update()
    {
        _numOfHearts = PlayerHealth.Instance.Get_CurrentHealth();
        _numOfspecialHearts = PlayerHealth.Instance.Get_ProtectionHeart();

        SpecialHeart();
        DefaultHeart();
    }

    private void DefaultHeart()
    {
        if (_numOfspecialHearts <= 0)
        {
            for (int i = 0; i < _hearts.Length; i++)
            {
                if (i < _numOfHearts)
                {
                    _hearts[i].SetActive(true);
                }
                else
                {
                    _hearts[i].SetActive(false);
                }
            }
        }
    }

    private void SpecialHeart()
    {
        for (int i = 0; i < _specialHearts.Length; i++)
        {
            if (i >= _specialHearts.Length - _numOfspecialHearts)
            {
                _specialHearts[i].SetActive(true);
            }
            else
            {
                _specialHearts[i].SetActive(false);
            }
        }
    }
}
