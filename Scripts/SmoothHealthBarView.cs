using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SmoothHealthBarView : HealthView
{
    [SerializeField] private float _animationDuration = 0.3f;

    private Slider _slider;
    private float _targetValue;
    private Coroutine _animation;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        _targetValue = _slider.value;
    }

    protected override void UpdateView(float value)
    {
        float targetValue = value / Health.MaxValue;

        if (_animation != null)
            StopCoroutine(_animation);

        _animation = StartCoroutine(AnimateRoutine(targetValue));
    }

    private IEnumerator AnimateRoutine(float targetValue)
    {
        float startValue = _slider.value;
        float elapsedTime = 0f;

        while (elapsedTime < _animationDuration)
        {
            elapsedTime += Time.deltaTime;
            float progress = elapsedTime / _animationDuration;

            _slider.value = Mathf.Lerp(startValue, targetValue, progress);

            yield return null;
        }

        _slider.value = targetValue;
    }
}