
using System;
using UnityEngine;

public class Score
{
    public event Action<int> OnCurrentChanged;
    public event Action<int> OnMaxChanged;

    public int CurrentValue
    {
        get => _currentValue;
        set
        {
            if (_currentValue == value)
                return;

            OnCurrentChanged?.Invoke(value);
            _currentValue = value;
        }
    }
    private int _currentValue;

    public int MaxValue
    {
        get => _maxValue;
        set
        {
            if (_maxValue == value)
                return;

            OnMaxChanged?.Invoke(value);
            _maxValue = value;
        }
    }
    private int _maxValue;

    public void Init()
    {

    }
}
