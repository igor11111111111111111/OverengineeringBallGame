
using UnityEngine;

public class BallEventHandler : MonoBehaviour
{
    [SerializeField] private BallParticleSystem _particleSystem;
    private Score _score;
    private Ball _ball;


    public void Init(Ball ball, Score score)
    {
        _ball = ball;
        _score = score;
        Sub();
    }

    private void Sub()
    {
        _ball.OnPlayerKilledMe += PlayerKilledMeHandler;
        _ball.OnTakeDamage += TakeDamageHandler;
    }

    private void OnDestroy()
    {
        _ball.OnPlayerKilledMe -= PlayerKilledMeHandler;
        _ball.OnTakeDamage -= TakeDamageHandler;
    }

    private void PlayerKilledMeHandler()
    {
        _particleSystem.SetNullParent();
        _score.CurrentValue++;
    }

    private void TakeDamageHandler()
    {
        _particleSystem.ChangeColor(_ball.CurrentColor);
        _particleSystem.Play();
    }
}
