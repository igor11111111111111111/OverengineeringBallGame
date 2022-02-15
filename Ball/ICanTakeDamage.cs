public interface ICanTakeDamage
{
    public enum Damager { Player, DeathArea}
     
    public void TakeDamage(Damager damager);
}
