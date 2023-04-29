using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _maxHP;
    private float _currentHP;

    public delegate void HealthChangeHandler(float damage);
    public event HealthChangeHandler OnTakeDamage;
    public event HealthChangeHandler OnHeel;

    public void TakeDamage(float damage)
    {
        _currentHP -= damage;
        if (_currentHP <= 0)
        {
            _currentHP = 0;
            Die();
        }
        OnTakeDamage?.Invoke(damage);
    }

    private void Die()
    {
        Debug.Log(gameObject.name + " умер...");
    }

    public void Heel(float value)
    {
        _currentHP += value;
        if (_currentHP > _maxHP)
        {
            _currentHP = _maxHP;
        }
        OnHeel?.Invoke(value);
    }
}