using UnityEngine;

public class CameraCorner
{
    public float Up => LeftUp.y;
    public float Down => RightDown.y;
    public float Left => LeftUp.x;
    public float Right => RightDown.x;

    public float OffsetedUp => LeftUp.y + _upOffset;
    public float OffsetedDown => RightDown.y + _downOffset;
    public float OffsetedLeft => LeftUp.x + _leftOffset;
    public float OffsetedRight => RightDown.x + _rightOffset;

    public Vector2 LeftUp => _camera.ScreenToWorldPoint(new Vector2(0, Screen.height));
    public Vector2 RightUp => _camera.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    public Vector2 LeftDown => _camera.ScreenToWorldPoint(new Vector3(0, 0));
    public Vector2 RightDown => _camera.ScreenToWorldPoint(new Vector3(Screen.width, 0));

    public const float COEFF_SCREEN_EXPANSION = 0.23f;

    private float _leftOffset = 1;
    private float _rightOffset = -1;
    private float _upOffset = 1;
    private float _downOffset = -1;

    private Camera _camera;

    public CameraCorner(Camera camera)
    {
        _camera = camera;
    }
}
