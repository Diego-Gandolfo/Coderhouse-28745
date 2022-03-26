using UnityEngine;

public abstract class ActorShooting : MonoBehaviour
{
    [SerializeField] private Transform _spawnpoint;

    protected IBulletStats _bulletStats;

    protected void Shoot()
    {
        var bullet = Instantiate(_bulletStats.Prefab, _spawnpoint.position, transform.rotation);
        bullet.SetBulletStats(_bulletStats);
    }

    public void SetBulletStats(IBulletStats bulletStats)
    {
        _bulletStats = bulletStats;
    }
}
