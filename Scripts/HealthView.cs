using UnityEngine;

public abstract class HealthView : MonoBehaviour
{
    [SerializeField] private Health _health;

    protected Health Health => _health;

    private void OnEnable()
    {
        _health.ValueChanged += UpdateView;
    }

    private void Start()
    {
        UpdateView(_health.CurrentValue);
    }

    private void OnDisable()
    {
        _health.ValueChanged -= UpdateView;
    }

    protected abstract void UpdateView(float value);
}