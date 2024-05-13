using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoSingleton<PlayerHealth>
{
    private int _maxHealth;
    private int _currentHealth;

    private int _reduceHealthBy;

    private int _protectionHeart;
    private float _protectionTime;

    private bool _isDamaged = false;
    private bool _isProtection = false;

    public void SetPlayerHealth(StatisticComponent p_statisticComponent)
    {
        _maxHealth = p_statisticComponent.MaxHealth;
        _reduceHealthBy = p_statisticComponent.Damage;
        _protectionHeart = p_statisticComponent.ProtectionHeart;
        _protectionTime = p_statisticComponent.ProtectionTime;

        _currentHealth = _maxHealth;
    }

    public void ReduceHealth()
    {
        if (_protectionHeart == 0)
            _currentHealth -= _reduceHealthBy;
        else
            _protectionHeart -= _reduceHealthBy;

        _isProtection = true;
        _isDamaged = false;

        StartCoroutine(Protection(_protectionTime));

        Debug.Log(_currentHealth);

        if (_currentHealth <= 0)
        {
            gameObject.SetActive(false);
            GameManager.Instance.MoveSpeedY = 0;
        }
    }

    private IEnumerator Protection(float p_delay)
    {
        int startValue = -50;
        float endValue = GameManager.Instance.MoveSpeedY;
        float duration = 1f;
        float timer = 0f;

        GameManager.Instance.MoveSpeedY = -50;

        while (timer < duration)
        {
            float progress = timer / duration;
            int newValue = (int)Mathf.Lerp(startValue, endValue, progress);
            GameManager.Instance.MoveSpeedY = newValue;
            timer += Time.deltaTime;
            yield return null;
        }

        GameManager.Instance.MoveSpeedY = endValue;

        yield return new WaitForSeconds(p_delay);

        _isProtection = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Die"))
        {
            if (!_isProtection)
            {
                _isDamaged = true;
            }
        }
    }

    public bool Get_IsDamaged() { return _isDamaged; }

    public bool Get_IsProtection() { return _isProtection; }

    public int Get_CurrentHealth() { return _currentHealth; }

    public int Get_ProtectionHeart() { return _protectionHeart; }
}