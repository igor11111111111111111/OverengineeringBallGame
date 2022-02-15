
using System;
using UnityEngine;

public class PanelBody : MonoBehaviour
{
    public event Action<bool> OnActive;

    private void OnEnable()
    {
        OnActive?.Invoke(true);
    }

    private void OnDisable()
    {
        OnActive?.Invoke(false);
    }

    public bool GetActive()
    {
        return gameObject.activeSelf;
    }

    public void SetActive(bool active)
    {
        gameObject.SetActive(active);
    }

    public void SwitchActive()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
