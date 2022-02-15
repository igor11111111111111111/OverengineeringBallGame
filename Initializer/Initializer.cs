
using UnityEngine;

public class Initializer : MonoBehaviour
{
    [SerializeField] private Canvas _mainCanvas;
    [SerializeField] private Canvas _endGameCanvas;
    private Camera _camera;
    private CameraCorner _cameraCorner;
    private Difficulty _difficulty;
    private Player _player;
    private Score _score;
    private BallSpawner _spawner;
    private TimeSystem _timeSystem;
    private RestartSystem _restartSystem;
    private ExitSystem _exitSystem;

    private ResourcesExtension _resourcesHandler;

    private void Awake() 
    {
        Modules();

        Player();
        Score();

        MenuUI();
        ScoreUI();
        PlayerHealthUI();
        EndGameUI();

        SaveSystem();
        PlayerInput();
        Difficulty();
        DeathArea();
        BackGround();
        Spawner();

        LateInit();
    }

    private void Modules()
    {
        var prefab = Resources.Load<ResourcesExtension>(typeof(ResourcesExtension).ToString());
        _resourcesHandler = Instantiate(prefab);
        _camera = Camera.main;
        _cameraCorner = new CameraCorner(_camera);
        _timeSystem = new TimeSystem();
        _restartSystem = new RestartSystem();
        _exitSystem = new ExitSystem();
    }

    private void MenuUI()
    {
        MenuPanel menuPanel = _resourcesHandler.LoadUI<MenuPanel>(_mainCanvas);
        menuPanel.Init();

        MenuTimeHandler menuTimeHandler = new MenuTimeHandler();
        menuTimeHandler.Init(_timeSystem, menuPanel);
    }

    private void ScoreUI()
    {
        ScorePanel scorePanel = _resourcesHandler.LoadUI<ScorePanel>(_mainCanvas);
        scorePanel.Init();

        UIScoreHandler uIScoreHandler = new UIScoreHandler();
        uIScoreHandler.Init(_score, scorePanel);
    }

    private void PlayerHealthUI()
    {
        PlayerHealthPanel healthPanel = _resourcesHandler.LoadUI<PlayerHealthPanel>(_mainCanvas);
        healthPanel.Init();

        UIPlayerHealthHandler healthHandler = new UIPlayerHealthHandler();
        healthHandler.Init(_player, healthPanel);
    }

    private void EndGameUI()
    {
        EndGamePanel endGamePanel = _resourcesHandler.LoadUI<EndGamePanel>(_endGameCanvas);
        endGamePanel.Init();

        MainCanvasRaycasterHandler mainCanvasRaycaster = new MainCanvasRaycasterHandler();
        mainCanvasRaycaster.Init(_mainCanvas);

        PlayerDeathEventHandler deathEventHandler = new PlayerDeathEventHandler();
        deathEventHandler.Init(_player, _timeSystem, endGamePanel, mainCanvasRaycaster);

        UIButtonRestartHandler restartHandler = new UIButtonRestartHandler();
        restartHandler.Init(endGamePanel.Restart, _restartSystem, mainCanvasRaycaster, _timeSystem);

        UIButtonExitGameHandler exitHandler = new UIButtonExitGameHandler();
        exitHandler.Init(_exitSystem, endGamePanel.Exit);
    }

    private void Player()
    {
        _player = new Player(2);
        _player.Init();
    }

    private void Score()
    {
        _score = new Score();
        _score.Init();
    }

    private void SaveSystem()
    {
        PlayerScoreSaveHandler playerScoreSaveHandler = _resourcesHandler.Load<PlayerScoreSaveHandler>();
        playerScoreSaveHandler.Init(_player, _score);
        playerScoreSaveHandler.Load();
    }

    private void PlayerInput()
    {
        PlayerInput playerInput = _resourcesHandler.Load<PlayerInput>();
        playerInput.Init();
    }

    private void Difficulty()
    {
        Difficulty difficulty = _resourcesHandler.Load<Difficulty>();
        difficulty.Init();
        _difficulty = difficulty;
    }

    private void DeathArea()
    {
        DeathArea deathArea = _resourcesHandler.Load<DeathArea>();
        DeathAreaSettings deathAreaSettings = new DeathAreaSettings(_cameraCorner);
        deathArea.Init(deathAreaSettings, _player);
    }

    private void BackGround()
    {
        BackGround backGround = _resourcesHandler.Load<BackGround>();
        BackGroundSettings backGroundSettings = new BackGroundSettings(_cameraCorner);
        backGround.Init(backGroundSettings);
    }

    private void Spawner()
    {
        _spawner = _resourcesHandler.Load<BallSpawner>();
        SpawnPosition spawnPosition = new SpawnPosition(_cameraCorner);
        _spawner.Init(spawnPosition, _difficulty, _score);
        _spawner.StartSpawn();
    }

    private void LateInit()
    {
        _player.LateInit();
    }
}

