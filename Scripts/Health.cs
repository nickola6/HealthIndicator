using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    private const int MinValue = 0;

    [SerializeField] private float _maxValue = 100f;

    public event Action<float> ValueChanged;
    public event Action Died;

    private bool _isDead;

    public float MaxValue => _maxValue;
    public float CurrentValue { get; private set; }

    private void Awake()
    {
        CurrentValue = _maxValue;
    }

    public void TakeDamage(float damage)
    {
        if (_isDead)
            return;

        if (damage < 0)
            throw new ArgumentOutOfRangeException(nameof(damage));

        CurrentValue = Mathf.Clamp(CurrentValue - damage, MinValue, _maxValue);
        ValueChanged?.Invoke(CurrentValue);

        if (CurrentValue == MinValue)
        {
            _isDead = true;
            Died?.Invoke();
        }
    }

    public void Heal(float value)
    {
        if (_isDead)
            return;

        if (value < 0)
            throw new ArgumentOutOfRangeException(nameof(value));

        CurrentValue = Mathf.Clamp(CurrentValue + value, MinValue, _maxValue);
        ValueChanged?.Invoke(CurrentValue);
    }
}