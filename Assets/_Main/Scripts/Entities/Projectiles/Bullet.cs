using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour, IBullet
{
    [SerializeField] private float _timeToDestroy;

    private IBulletStats _bulletStats;

    private Rigidbody _rigidbody;

    private void Start()
    {
        StartCoroutine(DestroyTimer(_timeToDestroy));
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        BulletMovement();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }

    private void BulletMovement()
    {
        _rigidbody.velocity = transform.forward * _bulletStats.BulletVelocity;
    }

    public void SetBulletStats(IBulletStats bulletStats)
    {
        _bulletStats = bulletStats;
    }

    IEnumerator DestroyTimer(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
