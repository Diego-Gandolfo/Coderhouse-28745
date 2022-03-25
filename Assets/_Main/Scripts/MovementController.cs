using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] private float _movementVelocity;

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
        var y = Input.GetAxisRaw("Vertical");

        var move = new Vector3(x, 0, y);

        move.Normalize();

        Movement(move);
    }

    private void Movement(Vector3 direction)
    {
        var move = transform.position + (direction * _movementVelocity);

        _rigidbody.MovePosition(move);
    }
}
