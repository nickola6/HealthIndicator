using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class HealthTextView : HealthView
{
    private TMP_Text _text;

    private void Awake()
    {
        _text = GetComponent<TMP_Text>();
    }

    protected override void UpdateView(float value)
    {
        _text.text = $"{value:0}/{Health.MaxValue:0}";
    }
}