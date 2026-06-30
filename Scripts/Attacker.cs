using UnityEngine;
using UnityEngine.UI;

public class Attacker : MonoBehaviour
{
    [SerializeField] private Button _damageButton;
    [SerializeField] private Health _health;
    [SerializeField] private float _damage = 15f;

    private void OnEnable()
    {
        _damageButton.onClick.AddListener(Attack);
    }

    private void OnDisable()
    {
        _damageButton.onClick.RemoveListener(Attack);
    }

    private void Attack()
    {
        _health.TakeDamage(_damage);
    }
}