using UnityEngine;

public class TimeSystem
{
    public void Active(bool active)
    {
        Time.timeScale = active ? 1 : 0;
    }
}

