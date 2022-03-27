using UnityEngine;

public class PlayerHealth : ActorHealth
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
