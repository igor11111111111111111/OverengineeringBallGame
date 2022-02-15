using UnityEngine;

public class BackGround : MonoBehaviour
{
    public void Init(BackGroundSettings backGroundSettings)
    {
        ChangeScale(backGroundSettings.GetSize());
    }

    private void ChangeScale(Vector3 scale)
    {
        transform.localScale = scale;
    }
}
