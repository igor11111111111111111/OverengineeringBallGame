using UnityEngine;
using UnityEngine.UI;

public class MainCanvasRaycasterHandler
{
    private GraphicRaycaster _graphicRaycaster;

    public void Init(Canvas canvas)
    {
        _graphicRaycaster = canvas.GetComponent<GraphicRaycaster>();
    }

    public void Enabled(bool active)
    {
        _graphicRaycaster.enabled = active;
    }
}
