using UnityEngine;

public class PlayerController : ActorController
{
    [SerializeField] private BulletStats _bulletStats;

    private ActorShooting _actorShooting;

    protected override void Awake()
    {
        base.Awake();
        InitializeComponents();
    }

    private void InitializeComponents()
    {
        _actorShooting = GetComponent<ActorShooting>();
        _actorShooting.SetBulletStats(_bulletStats);
    }
}
