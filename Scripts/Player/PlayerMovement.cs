using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoSingleton<PlayerMovement>
{
    private bool _isMovable = true;

    public void ControlLogic(StatisticComponent p_stats, Rigidbody2D p_rigidbody)
    {
        float scrollInput = Input.GetAxis("Mouse ScrollWheel");

        if (scrollInput > 0)
        {
            p_rigidbody.velocity = new Vector2(-p_stats.MoveSpeed, p_rigidbody.velocity.y);
        }
        else if (scrollInput < 0)
        {
            p_rigidbody.velocity = new Vector2(p_stats.MoveSpeed, p_rigidbody.velocity.y);
        }
    }

    public bool Get_IsMovable() { return _isMovable;}
}