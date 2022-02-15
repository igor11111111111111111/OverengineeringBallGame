using UnityEngine;

public class SpawnPosition
{
    private CameraCorner _cameraCorner;
    private Vector2 _offscreenShift = new Vector2(1, 2);

    public SpawnPosition(CameraCorner cameraCorner)
    {
        _cameraCorner = cameraCorner;
    }

    public Vector3 GetRandom()
    {
        var leftX = _cameraCorner.OffsetedLeft;
        var rightX = _cameraCorner.OffsetedRight;
        var posY = _cameraCorner.OffsetedUp;

        return new Vector3(Random.Range(leftX, rightX), posY);
    }
}