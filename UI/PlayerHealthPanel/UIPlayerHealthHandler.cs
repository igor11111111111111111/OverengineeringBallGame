
public class UIPlayerHealthHandler
{ 
    public void Init(Player player, PlayerHealthPanel panel)
    {
        player.OnHealthChanged += panel.Refresh;
    }
}
