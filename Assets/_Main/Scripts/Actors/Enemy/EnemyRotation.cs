using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotation : ActorRotation
{
    private IConeOfSight _coneOfSight;
    private PlayerController _playerController;

    private void Start()
    {
        _playerController = LevelManager.Instance.Player;
    }

    private void LookAtPlayer()
    {
        var direction = (_playerController.transform.position - transform.position).normalized;
        LookAtDirection(direction);
    }

    public void SetConeOfSight(IConeOfSight coneOfSight)
    {
        _coneOfSight = coneOfSight;
        _coneOfSight.OnSight += LookAtPlayer;
    }
}
