using System.Collections;
using UnityEngine;

public class Difficulty : MonoBehaviour
{
    private float _startValue = 1; // >= 1
    public float SpawnBallTime => 1 / _currentValue;
    public float CurrentValue => _currentValue;
    private float _currentValue;
    private float _step = 1.025f; // > 1

    public void Init()
    {
        _currentValue = _startValue;
        StartCoroutine(CustomUpdate());
    }

    private IEnumerator CustomUpdate()
    {
        while (true)
        {
            IncreaseDifficulty();
            yield return new WaitForSeconds(1);
        }
    }

    private void IncreaseDifficulty()
    {
        _currentValue *= _step;
    }
}
