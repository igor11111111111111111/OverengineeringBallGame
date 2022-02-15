
public class MenuTimeHandler
{
    public void Init(TimeSystem time, MenuPanel menuPanel)
    {
        menuPanel.OnActive += (active) => time.Active(!active);
    }
     
}
