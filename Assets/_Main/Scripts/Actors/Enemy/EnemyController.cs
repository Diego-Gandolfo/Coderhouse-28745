using UnityEngine;

public class EnemyController : ActorController, IEnemyController
{
    [SerializeField] private ConeOfSight _coneOfSight;

    private PlayerController _player;

    public PlayerController Player => _player;

    private void Start()
    {
        _player = LevelManager.Instance.Player;

        ((EnemyMovement)ActorMovement).SetActorController(this);
        ((EnemyRotation)ActorRotation).SetActorController(this);
        ((EnemyShooting)ActorShooting).SetActorController(this);

        ((EnemyMovement)ActorMovement).SetConeOfSight(_coneOfSight);
        ((EnemyRotation)ActorRotation).SetConeOfSight(_coneOfSight);
        ((EnemyShooting)ActorShooting).SetConeOfSight(_coneOfSight);
    }
}
