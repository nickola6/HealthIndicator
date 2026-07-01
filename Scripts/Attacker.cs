using UnityEngine;

public class Attacker : ButtonAction
{
    [SerializeField] private float _damage = 15f;

    protected override void PerformAction()
    {
        _health.TakeDamage(_damage);
    }
}