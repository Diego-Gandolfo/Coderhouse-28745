using UnityEngine;

public class ActorController : MonoBehaviour, IActorController
{
    [SerializeField] protected ActorStats _actorStats;

    protected Rigidbody _rigidbody;
    protected ActorMovement _actorMovement;
    protected ActorRotation _actorRotation;

    public Rigidbody Rigidbody => _rigidbody;

    private void Start()
    {
        InitializeComponents();
    }

    private void InitializeComponents()
    {
        _rigidbody = GetComponent<Rigidbody>();

        _actorMovement = GetComponent<ActorMovement>();
        _actorMovement.SetActorController(this);
        _actorMovement.SetActorStats(_actorStats);

        _actorRotation = GetComponent<ActorRotation>();
        _actorRotation.SetActorController(this);
        _actorRotation.SetActorStats(_actorStats);
    }
}
