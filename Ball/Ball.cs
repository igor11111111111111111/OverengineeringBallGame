
using System;
using UnityEngine;

public class Ball : MonoBehaviour, ICanTakeDamage
{
    public event Action OnTakeDamage;
    public event Action OnPlayerKilledMe;

    [SerializeField] private Rigidbody _rigidBody;
    [SerializeField] private MeshRenderer _meshRenderer;
    public Color CurrentColor => _currentColor;
    private Color _currentColor;

    public void Init()
    {
        SetRandomColor();
    }

    public void Run(Difficulty difficulty)
    {
        AddForce(difficulty);
    }

    public void TakeDamage(ICanTakeDamage.Damager damager)
    {
        OnTakeDamage?.Invoke();
        TakeDamageHandler(damager);
    }

    private void AddForce(Difficulty difficulty)
    {
        Vector3 force = new Vector3(0, -difficulty.CurrentValue, 0);
        _rigidBody.AddForce(force, ForceMode.Impulse);
    }

    private void SetRandomColor()
    {
        var newColor = new ColorExtension().GetRandom();
        _meshRenderer.material.color = _currentColor = newColor;
    }

    private void TakeDamageHandler(ICanTakeDamage.Damager damager)
    {
        if(damager == ICanTakeDamage.Damager.Player)
        {
            OnPlayerKilledMe?.Invoke();
        }

        Destroy();
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }
}
