
public class PlayerDeathEventHandler
{
    public void Init(Player player, TimeSystem time, EndGamePanel panel, MainCanvasRaycasterHandler raycaster)
    {
        player.OnDeath += () => panel.SetActive(true);
        player.OnDeath += () => time.Active(false);
        player.OnDeath += () => raycaster.Enabled(false);
    } 
}
 