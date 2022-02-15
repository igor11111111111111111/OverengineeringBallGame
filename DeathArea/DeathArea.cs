using UnityEngine;

public class DeathArea : MonoBehaviour
{
    [SerializeField] private DeathAreaTrigger _trigger;

    public void Init(DeathAreaSettings deathAreaSettings, ICanTakeDamage player)
    {
        _trigger.Init(player);
        ChangeScale(deathAreaSettings.GetSize());
        ChangePosition(deathAreaSettings.GetPosition());
    }
     
    private void ChangeScale(Vector3 scale)
    {
        transform.localScale = scale;
    }

    private void ChangePosition(Vector3 position)
    {
        transform.position = position;
    }
}
