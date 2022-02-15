
using System.Collections;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] private Ball _ballPrefab;
    private SpawnPosition _spawnPosition;
    private Difficulty _difficulty;
    private Score _score;

    public void Init(SpawnPosition spawnPosition, Difficulty difficulty, Score score)
    {
        _spawnPosition = spawnPosition;
        _difficulty = difficulty;
        _score = score;
    }

    public void StartSpawn()
    {
        StartCoroutine(CustomUpdate());
    }

    private IEnumerator CustomUpdate()
    {
        while (true)
        {
            Spawn(_spawnPosition.GetRandom());
            yield return new WaitForSeconds(_difficulty.SpawnBallTime);
        }
    }

    private void Spawn(Vector3 position)
    {
        Ball ball = Instantiate(_ballPrefab, position, Quaternion.identity, transform);
        ball.Init();
        ball.Run(_difficulty);

        BallEventHandler eventHandler = ball.GetComponent<BallEventHandler>();
        eventHandler.Init(ball, _score);
    }
}
