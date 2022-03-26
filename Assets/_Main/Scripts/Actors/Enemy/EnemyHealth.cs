using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : ActorHealth
{
    protected override void Start()
    {
        base.Start();

        OnDie += Die;
    }

    protected override void Die()
    {
        Destroy(gameObject);
    }
}
