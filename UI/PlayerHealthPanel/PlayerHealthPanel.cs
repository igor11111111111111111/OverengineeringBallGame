
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthPanel : MonoBehaviour
{
    [SerializeField] private Text _text;

    public void Init()
    {

    } 

    public void Refresh(int current, int max)
    {
        _text.text = "Health " + current + " / " + max;
    }
}
