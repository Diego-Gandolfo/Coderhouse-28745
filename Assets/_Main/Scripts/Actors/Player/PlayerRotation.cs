using UnityEngine;

public class PlayerRotation : ActorRotation
{
    private Camera _mainCamera;

    private void Start()
    {
        _mainCamera = Camera.main;
    }

    private void Update()
    {
        var direction = GetDirection();
        LookAtDirection(direction);
    }

    private Vector3 GetDirection()
    {
        var mousePosition = _mainCamera.ScreenToWorldPoint(Input.mousePosition);
        var groundPosition = Vector3.zero;

        RaycastHit hit;
        if (Physics.Raycast(mousePosition, Vector3.down, out hit, Mathf.Infinity, LayerMask.GetMask("Ground")))
        {
            groundPosition = hit.point;
        }

        var direction = new Vector3(groundPosition.x - transform.position.x, transform.position.y, groundPosition.z - transform.position.z);

        return direction;
    }
}
