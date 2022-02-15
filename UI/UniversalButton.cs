
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
 
public class UniversalButton : MonoBehaviour
{
    [SerializeField] private PanelBody _body;
    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
        _body.SetActive(false);

        _button.onClick.AddListener(_body.SwitchActive);
    }
}
