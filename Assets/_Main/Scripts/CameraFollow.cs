using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private float distance;

    private Transform _player;

    private void Start()
    {
        _player = LevelManager.Instance.Player.transform;
    }
    private void Update()
    {
        transform.position = new Vector3(_player.position.x, distance, _player.position.z);
    }
}
