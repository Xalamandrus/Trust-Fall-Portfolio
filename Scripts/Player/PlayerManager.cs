using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoSingleton<PlayerManager>
{
    [SerializeField] private StatisticComponent _statisticComponent;

    private Rigidbody2D _rigidbody;
    private Animator _animator;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();

        PlayerHealth.Instance.SetPlayerHealth(_statisticComponent);
    }

    private void Update()
    {
        if (PlayerMovement.Instance.Get_IsMovable())
            PlayerMovement.Instance.ControlLogic(_statisticComponent, _rigidbody);

        if (!PlayerHealth.Instance.Get_IsProtection())
            _animator.Play("Falling");

        if (PlayerHealth.Instance.Get_IsDamaged())
        {
            _animator.Play("Damaged");
            PlayerHealth.Instance.ReduceHealth();
        }
    }

    public Rigidbody2D Get_RigidbodyPlayer() { return _rigidbody; }
}