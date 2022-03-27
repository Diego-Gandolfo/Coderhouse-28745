using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private EnemyController _enemyPrefab;
    [SerializeField] private Vector2 _spawnArea;
    [SerializeField] private float _cooldown;

    private bool _canSpawn;

    private void Start()
    {
        _canSpawn = true;
    }

    private void Update()
    {
        if (_canSpawn)
        {
            var x = Random.Range(-_spawnArea.x, _spawnArea.x);
            var y = Random.Range(0, 360);
            var z = Random.Range(-_spawnArea.y, _spawnArea.y);

            var position = new Vector3(x, 0f, z);
            var rotation = new Vector3(0f, y, 0f);

            Instantiate(_enemyPrefab, position, Quaternion.Euler(rotation));
            StartCoroutine(CooldownCounter());
        }
    }

    private IEnumerator CooldownCounter()
    {
        _canSpawn = false;
        yield return new WaitForSeconds(_cooldown);
        _canSpawn = true;
    }
}
