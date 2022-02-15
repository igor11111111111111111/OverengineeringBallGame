
using System;

public class Player : ICanTakeDamage
{
    public event Action OnTakeDamage;
    public event Action<int, int> OnHealthChanged;
    public event Action OnDeath;

    public int CurrentHealth 
    { 
        get => _currentHealth; 

        set
        {
            if (_currentHealth == value || value < 0) 
                return;

            if (value == 0)
                OnDeath?.Invoke();

            OnHealthChanged?.Invoke(value, _maxHealth);
            _currentHealth = value;
        } 
    }
    private int _currentHealth;
    public int MaxHealth => _maxHealth;
    private int _maxHealth;

    public Player(int maxHealth)
    {
        _maxHealth = maxHealth;
        _currentHealth = _maxHealth;
    }

    public void Init()
    {
        OnTakeDamage += () => CurrentHealth--;
    }

    public void LateInit()
    {
        OnHealthChanged?.Invoke(_currentHealth, _maxHealth);
    }

    public void TakeDamage(ICanTakeDamage.Damager damager)
    {
        OnTakeDamage?.Invoke();
    }
}
