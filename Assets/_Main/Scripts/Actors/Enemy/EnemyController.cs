using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : ActorController
{
    [SerializeField] private ConeOfSight _coneOfSight;

    private void Start()
    {
        ((EnemyMovement)ActorMovement).SetConeOfSight(_coneOfSight);
        ((EnemyRotation)ActorRotation).SetConeOfSight(_coneOfSight);
    }
}
