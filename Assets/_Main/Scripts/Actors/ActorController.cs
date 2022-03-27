using UnityEngine;

public abstract class ActorController : MonoBehaviour, IActorController
{
    [SerializeField] private ActorStats _actorStats;
    [SerializeField] private BulletStats _bulletStats;

    private Rigidbody _rigidbody;
    private ActorHealth _actorHealth;
    private ActorMovement _actorMovement;
    private ActorRotation _actorRotation;
    private ActorShooting _actorShooting;

    public Rigidbody Rigidbody => _rigidbody;
    public ActorMovement ActorMovement => _actorMovement;
    public ActorRotation ActorRotation => _actorRotation;
    public ActorShooting ActorShooting => _actorShooting;

    protected virtual void Awake()
    {
        InitializeComponents();
    }

    private void InitializeComponents()
    {
        _rigidbody = GetComponent<Rigidbody>();

        _actorHealth = GetComponent<ActorHealth>();
        _actorHealth?.SetActorStats(_actorStats);

        _actorMovement = GetComponent<ActorMovement>();
        _actorMovement?.SetActorController(this);
        _actorMovement?.SetActorStats(_actorStats);

        _actorRotation = GetComponent<ActorRotation>();
        _actorRotation?.SetActorStats(_actorStats);

        _actorShooting = GetComponent<ActorShooting>();
        _actorShooting?.SetBulletStats(_bulletStats);
    }
}
