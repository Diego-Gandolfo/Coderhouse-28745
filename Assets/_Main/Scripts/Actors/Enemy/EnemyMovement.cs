using UnityEngine;

public class EnemyMovement : ActorMovement
{
    [SerializeField] private float _stopDistance;

    private IConeOfSight _coneOfSight;
    private IEnemyController _enemyController;

    private void MoveToPlayer()
    {
        if (CheckDistance())
        {
            var direction = (_enemyController.Player.transform.position - transform.position).normalized;
            Movement(direction);
        }
    }

    private bool CheckDistance()
    {
        var distance = (_enemyController.Player.transform.position - transform.position).magnitude;
        return (distance > _stopDistance);
    }

    public void SetConeOfSight(IConeOfSight coneOfSight)
    {
        _coneOfSight = coneOfSight;
        _coneOfSight.OnSight += MoveToPlayer;
    }

    public void SetActorController(IEnemyController enemyController)
    {
        _enemyController = enemyController;
    }
}
