using UnityEngine;

[CreateAssetMenu(fileName = "New_BulletStats", menuName = "Flyweight/Stats/Bullet", order = 0)]
public class BulletStats : ScriptableObject, IBulletStats
{
    [SerializeField] private Bullet _bulletPrefab;
    [SerializeField] private float _bulletVelocity;

    public Bullet BulletPrefab => _bulletPrefab;
    public float BulletVelocity => _bulletVelocity;
}
