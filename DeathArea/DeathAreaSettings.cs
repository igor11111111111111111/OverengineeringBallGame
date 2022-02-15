using UnityEngine;

public class DeathAreaSettings
{
    private CameraCorner _cameraCorner;

    public DeathAreaSettings(CameraCorner cameraCorner)
    {
        _cameraCorner = cameraCorner;
    }
      
    public Vector3 GetSize()
    {
        return new Vector3 (_cameraCorner.Left * CameraCorner.COEFF_SCREEN_EXPANSION, 1, 1);
    }

    public Vector3 GetPosition()
    {
        return Vector3.up * _cameraCorner.OffsetedDown;
    }
}
