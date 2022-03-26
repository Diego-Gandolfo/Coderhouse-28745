using UnityEngine;

public abstract class ActorController : MonoBehaviour, IActorController
{
    [SerializeField] private ActorStats _actorStats;

    private Rigidbody _rigidbody;
    private ActorMovement _actorMovement;
    private ActorRotation _actorRotation;
    private ActorHealth _actorHealth;

    public Rigidbody Rigidbody => _rigidbody;

    protected virtual void Awake()
    {
        InitializeComponents();
    }

    private void InitializeComponents()
    {
        _rigidbody = GetComponent<Rigidbody>();

        _actorMovement = GetComponent<ActorMovement>();
        _actorMovement?.SetActorController(this);
        _actorMovement?.SetActorStats(_actorStats);

        _actorRotation = GetComponent<ActorRotation>();
        _actorRotation?.SetActorStats(_actorStats);

        _actorHealth = GetComponent<ActorHealth>();
        _actorHealth?.SetActorStats(_actorStats);
    }
}
