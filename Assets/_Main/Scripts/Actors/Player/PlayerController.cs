using UnityEngine;

public class PlayerController : ActorController
{
    [SerializeField] protected BulletStats _bulletStats;

    private ActorShooting _actorShooting;

    protected override void Start()
    {
        base.Start();
        InitializeComponents();
    }

    private void InitializeComponents()
    {
        _actorShooting = GetComponent<ActorShooting>();
        _actorShooting.SetBulletStats(_bulletStats);
    }
}
