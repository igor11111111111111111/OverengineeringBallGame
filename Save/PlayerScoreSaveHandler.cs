
using UnityEngine;

public class PlayerScoreSaveHandler : MonoBehaviour
{
    private ScoreSaveSystem _scoreSaveSystem;
    private Score _score;

    public void Init(Player player, Score score)
    {
        _scoreSaveSystem = new ScoreSaveSystem();
        _score = score;

        player.OnDeath += Save;
    }

    private void OnApplicationQuit()
    {
        Save();
    }

    private void Save()
    {
        if (_score.CurrentValue > _score.MaxValue)
            _scoreSaveSystem.Save(_score.CurrentValue);
    }

    public void Load()
    {
        _score.MaxValue = _scoreSaveSystem.Load();
    }
}
