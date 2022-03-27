using UnityEngine;

public class EnemyShooting : ActorShooting
{
    [SerializeField] private float _range;

    private IEnemyController _enemyController;
    private IConeOfSight _coneOfSight;

    private void CheckShoot()
    {
        if (CanShoot && ChechPlayerInLine())
        {
            Shoot();
        }
    }

    private bool ChechPlayerInLine()
    {
        var result = Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, _range, BulletStats.TargetLayer);
         
        return result;
    }

    public void SetConeOfSight(IConeOfSight coneOfSight)
    {
        _coneOfSight = coneOfSight;
        _coneOfSight.OnSight += CheckShoot;
    }

    public void SetActorController(IEnemyController enemyController)
    {
        _enemyController = enemyController;
    }
}
