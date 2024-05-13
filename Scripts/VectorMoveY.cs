using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VectorMoveY : MonoBehaviour
{
    private Rigidbody2D _rb;

    private float _mMoveSpeedY;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _mMoveSpeedY = GameManager.Instance.Obscale;

        _rb.velocity = new Vector2(_rb.velocity.x, _mMoveSpeedY);

        if (transform.position.y > PoolingMapManager.Instance.YDeactivate)
        {
            gameObject.SetActive(false);
        }
    }
}