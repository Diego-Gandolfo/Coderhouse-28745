using System.Collections;
using UnityEngine;

public abstract class ActorShooting : MonoBehaviour
{
    [SerializeField] private Transform _spawnpoint;
    [SerializeField] private float _cooldown;

    private IBulletStats _bulletStats;

    private bool _canShoot;

    public IBulletStats BulletStats => _bulletStats;

    public float Cooldown => _cooldown;
    public bool CanShoot => _canShoot;

    protected virtual void Start()
    {
        _canShoot = true;
    }

    protected void Shoot()
    {
        _canShoot = false;
        var bullet = Instantiate(_bulletStats.Prefab, _spawnpoint.position, transform.rotation);
        bullet.SetBulletStats(_bulletStats);
        StartCoroutine(CooldownTimer(Cooldown));
    }

    public void SetCanShoot(bool value)
    {
        _canShoot = value;
    }

    public void SetBulletStats(IBulletStats bulletStats)
    {
        _bulletStats = bulletStats;
    }

    protected IEnumerator CooldownTimer(float time)
    {
        yield return new WaitForSeconds(time);
        _canShoot = true;
    }
}
