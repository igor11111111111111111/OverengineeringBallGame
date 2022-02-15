using UnityEngine;

public class BallParticleSystem : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystem;
    [SerializeField] private ParticleSystemRenderer _renderer;

    public void Play()
    {
        _particleSystem.Play();
    }

    public void ChangeColor(Color color)
    {
        _renderer.material.color = color;
    }

    public void SetNullParent()
    {
        _particleSystem.transform.SetParent(null);
    }
}
