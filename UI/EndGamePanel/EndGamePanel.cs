
using UnityEngine;
using UnityEngine.UI;

public class EndGamePanel : MonoBehaviour
{
    public Button Restart => _restart;
    [SerializeField] private Button _restart;
    public Button Exit => _exit;
    [SerializeField] private Button _exit;

    [SerializeField] private PanelBody _body;

    public void Init()
    {

    }

    public void SetActive(bool active)
    {
        _body.SetActive(active);
    }
}
