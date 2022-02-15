using UnityEngine;

public class ColorExtension
{
    public Color GetRandom()
    {
        return new Color(GetRandomColorComponent(), GetRandomColorComponent(), GetRandomColorComponent());
    }

    private float GetRandomColorComponent()
    {
        return Random.Range(0, 255) / 255f;
    }
}
