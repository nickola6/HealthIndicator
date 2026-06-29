using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SmoothHealthBarView : HealthView
{
    [SerializeField] private float _speed = 0.3f;

    private Slider _slider;
    private float _targetValue;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        _targetValue = _slider.value;
    }

    private void Update()
    {
        _slider.value = Mathf.MoveTowards(_slider.value, _targetValue, _speed * Time.deltaTime);
    }

    protected override void UpdateView(float value)
    {
        _targetValue = value / Health.MaxValue;
    }
}