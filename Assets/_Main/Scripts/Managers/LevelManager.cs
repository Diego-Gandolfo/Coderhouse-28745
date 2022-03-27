using UnityEngine;
using Cinemachine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;

    [SerializeField] private PlayerController _playerPrefab;
    [SerializeField] private Transform _spawnpoint;
    [SerializeField] private CinemachineVirtualCamera _virtualCamera;

    private PlayerController _player;

    public PlayerController Player => _player;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);

        var player = Instantiate(_playerPrefab, _spawnpoint.position, _spawnpoint.rotation);
        _player = player;
    }

    private void Start()
    {
        _virtualCamera.Follow = _player.gameObject.transform;
        _virtualCamera.LookAt = _player.gameObject.transform;
    }
}
