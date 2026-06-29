using UnityEngine;

public class Healer : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private float _healValue = 10f;

    public void Heal()
    {
        _health.Heal(_healValue);
    }
}