using UnityEngine;

public class ActorShooting : MonoBehaviour
{
    [SerializeField] private Transform _spawnpoint;

    protected IBulletStats _bulletStats;

    protected void Shoot()
    {
        var bullet = Instantiate(_bulletStats.BulletPrefab, _spawnpoint.position, transform.rotation);
        bullet.SetBulletStats(_bulletStats);
    }

    public void SetBulletStats(IBulletStats bulletStats)
    {
        _bulletStats = bulletStats;
    }
}
