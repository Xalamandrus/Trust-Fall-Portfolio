using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;

public class Stalactite : MonoBehaviour
{
    [Header("Stalactite Parm")]
    [Space]

    [SerializeField] private GameObject _stalactite;
    [SerializeField] private float _stalactiteDuration;

    [Header("Alert Parm")]
    [Space]

    [SerializeField] private GameObject _alert;
    [SerializeField] private float _alertDuration;

    private void OnEnable()
    {
        StartCoroutine(DisableComponent());
    }

    private IEnumerator DisableComponent()
    {
        _alert.SetActive(true);

        yield return new WaitForSeconds(_alertDuration);

        _alert.SetActive(false);

        yield return new WaitForSeconds(_stalactiteDuration);

        Destroy(gameObject);
    }
}
