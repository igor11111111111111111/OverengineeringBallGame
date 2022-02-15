using UnityEngine.UI;

public class UIButtonRestartHandler
{ 
    public void Init(Button restartButton, RestartSystem restartSystem, MainCanvasRaycasterHandler raycaster, TimeSystem timeSystem)
    {
        restartButton.onClick.AddListener(restartSystem.Restart);
        restartButton.onClick.AddListener(() => raycaster.Enabled(true));
        restartButton.onClick.AddListener(() => timeSystem.Active(true));
    }
} 
