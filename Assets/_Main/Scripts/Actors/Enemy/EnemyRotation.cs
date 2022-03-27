using UnityEngine;

public class EnemyRotation : ActorRotation
{
    private IConeOfSight _coneOfSight;
    private IEnemyController _enemyController;

    private void LookAtPlayer()
    {
        var direction = (_enemyController.Player.transform.position - transform.position).normalized;
        LookAtDirection(direction);
    }

    public void SetConeOfSight(IConeOfSight coneOfSight)
    {
        _coneOfSight = coneOfSight;
        _coneOfSight.OnSight += LookAtPlayer;
    }

    public void SetActorController(IEnemyController enemyController)
    {
        _enemyController = enemyController;
    }
}
