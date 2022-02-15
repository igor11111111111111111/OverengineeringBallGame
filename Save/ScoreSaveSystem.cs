using UnityEngine;

public class ScoreSaveSystem
{
    private string _key = "score";

    public void Save(int value)
    {
        PlayerPrefs.SetInt(_key, value);
    }

    public int Load()
    {
        return PlayerPrefs.GetInt(_key);
    }
}
