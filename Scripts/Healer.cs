using UnityEngine;
using UnityEngine.UI;

public class Healer : MonoBehaviour
{
    [SerializeField] private Button _healButton;
    [SerializeField] private Health _health;
    [SerializeField] private float _healValue = 10f;

    private void OnEnable()
    {
        _healButton.onClick.AddListener(Heal);
    }

    private void OnDisable()
    {
        _healButton.onClick.RemoveListener(Heal);
    }

    private void Heal()
    {
        _health.Heal(_healValue);
    }
}