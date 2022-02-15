using UnityEngine;

public class DeathAreaTrigger : MonoBehaviour
{
    private ICanTakeDamage _player;

    public void Init(ICanTakeDamage player)
    {
        _player = player;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out ICanTakeDamage takerDamage))
        {
            takerDamage.TakeDamage(ICanTakeDamage.Damager.DeathArea);
            _player.TakeDamage(ICanTakeDamage.Damager.DeathArea);
        }
    }
}