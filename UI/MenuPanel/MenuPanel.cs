
using System;
using UnityEngine;

public class MenuPanel : MonoBehaviour
{
    public event Action<bool> OnActive;
    [SerializeField] private PanelBody _body;

    public void Init()
    {
        _body.OnActive += (active) => OnActive?.Invoke(active);
    }
}
