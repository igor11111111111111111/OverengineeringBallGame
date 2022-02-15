
using UnityEngine;
using UnityEngine.UI;

public class ScorePanel : MonoBehaviour
{
    [SerializeField] private Text _max;
    [SerializeField] private Text _current;

    public void Init()
    {

    }

    public void RefreshMax(int max)
    {
        _max.text = "Max score : " + max;
    }

    public void RefreshCurrent(int current)
    {
        _current.text = "Score : " + current;
    }
}
