using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour, IActorController
{
    [SerializeField] private ActorStats _actorStats;

    private Rigidbody _rigidbody;
    private PlayerMovement _playerMovement;
    private PlayerRotation _playerRotation;

    public Rigidbody Rigidbody => _rigidbody;

    private void Start()
    {
        InitializeComponents();
    }

    private void InitializeComponents()
    {
        _rigidbody = GetComponent<Rigidbody>();

        _playerMovement = GetComponent<PlayerMovement>();
        _playerMovement.SetActorController(this);
        _playerMovement.SetActorStats(_actorStats);

        _playerRotation = GetComponent<PlayerRotation>();
        _playerRotation.SetActorController(this);
        _playerRotation.SetActorStats(_actorStats);
    }
}
