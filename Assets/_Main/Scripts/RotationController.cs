using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{
    [SerializeField] private float _rotationVelocity;

    private Camera _mainCamera;

    private void Start()
    {
        _mainCamera = Camera.main;
    }

    private void Update()
    {
        var mousePosition = _mainCamera.ScreenToWorldPoint(Input.mousePosition);

        var direction = new Vector3(mousePosition.x - transform.position.x, transform.position.y, mousePosition.z - transform.position.z);

        var wantedDirection = Quaternion.LookRotation(direction, Vector3.up);

        transform.rotation = Quaternion.Lerp(transform.rotation, wantedDirection, _rotationVelocity * Time.deltaTime);
    }
}
