using UnityEngine;

public class Healer : ButtonAction
{
    [SerializeField] private float _healValue = 10f;

    protected override void PerformAction()
    {
        _health.Heal(_healValue);
    }
}