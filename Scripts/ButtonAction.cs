using UnityEngine;
using UnityEngine.UI;

public abstract class ButtonAction : MonoBehaviour
{
    [SerializeField] protected Button _button;
    [SerializeField] protected Health _health;

    protected virtual void OnEnable()
    {
        _button.onClick.AddListener(PerformAction);
    }

    protected virtual void OnDisable()
    {
        _button.onClick.RemoveListener(PerformAction);
    }

    protected abstract void PerformAction();
}