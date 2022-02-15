using System;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public void Init()
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
            TryDamage();
    }

    private void TryDamage()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (!Physics.Raycast(ray, out hit))
            return;
        if (!hit.transform.TryGetComponent(out ICanTakeDamage takerDamage))
            return;

        takerDamage.TakeDamage(ICanTakeDamage.Damager.Player);
    }
}
