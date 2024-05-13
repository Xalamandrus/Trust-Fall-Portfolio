using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StalactiteEventTrigger : MonoBehaviour
{
    public delegate void StalactiteEvent();
    public static event StalactiteEvent OnStalactiteEvent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (OnStalactiteEvent != null)
            {
                OnStalactiteEvent();
            }
        }
    }
}
