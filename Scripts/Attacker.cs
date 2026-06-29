using UnityEngine;

public class Attacker : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private float _damage = 15f;

    public void Attack()
    {
        _health.TakeDamage(_damage);
    }
}