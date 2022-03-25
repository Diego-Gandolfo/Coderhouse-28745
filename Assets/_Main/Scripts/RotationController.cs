using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{
    private Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        var mouseScreenPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        //Debug.Log(mouseScreenPosition);
        //var direction = new Vector3(mouseScreenPosition.x, transform.position.y, mouseScreenPosition.z) - transform.position;
        //direction.Normalize();
        //transform.LookAt(direction);

        transform.LookAt(new Vector3(mouseScreenPosition.x, transform.position.y, mouseScreenPosition.z));
    }
}
