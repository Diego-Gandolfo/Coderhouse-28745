using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : ActorMovement
{
    private IConeOfSight _coneOfSight;

    private PlayerController _playerController;

    private void Start()
    {
        _playerController = LevelManager.Instance.Player;
    }

    private void MoveToPlayer()
    {
        var direction = (_playerController.transform.position - transform.position).normalized;
        Movement(direction);
    }

    public void SetConeOfSight(IConeOfSight coneOfSight)
    {
        _coneOfSight = coneOfSight;
        _coneOfSight.OnSight += MoveToPlayer;
    }
}
