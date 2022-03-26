using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] private float _movementVelocity = 10.0f;

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        InputCheck();
    }

    private void InputCheck()
    {
        var x = Input.GetAxisRaw("Horizontal");
        var y = 0;
        var z = Input.GetAxisRaw("Vertical");

        var move = new Vector3(x, y, z);

        move.Normalize();

        Movement(move);
    }

    private void Movement(Vector3 direction)
    {
        var move = transform.position + (direction * _movementVelocity);

        _rigidbody.velocity = (direction * _movementVelocity);
    }
}
