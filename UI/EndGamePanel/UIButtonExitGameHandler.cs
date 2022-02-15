using UnityEngine.UI;

public class UIButtonExitGameHandler
{
    public void Init(ExitSystem exitSystem, Button exitButton)
    {
        exitButton.onClick.AddListener(exitSystem.Exit);
    }
}
