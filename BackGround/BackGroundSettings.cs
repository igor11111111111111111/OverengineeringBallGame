using UnityEngine;

public class BackGroundSettings
{
    private CameraCorner _cameraCorner;

    public BackGroundSettings(CameraCorner cameraCorner)
    {
        _cameraCorner = cameraCorner;
    }

    public Vector3 GetSize()
    {
        return new Vector3(_cameraCorner.Left * CameraCorner.COEFF_SCREEN_EXPANSION, 1, 1);
    }
}
 