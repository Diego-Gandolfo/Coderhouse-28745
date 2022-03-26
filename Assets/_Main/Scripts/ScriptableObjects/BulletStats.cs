using UnityEngine;

[CreateAssetMenu(fileName = "New_BulletStats", menuName = "Flyweight/Stats/Bullet", order = 0)]
public class BulletStats : ScriptableObject, IBulletStats
{
    [SerializeField] private Bullet _prefab;
    [SerializeField] private float _velocity;
    [SerializeField] private float _damage;
    [SerializeField] private LayerMask _targetLayer;

    public Bullet Prefab => _prefab;
    public float Velocity => _velocity;
    public float Damage => _damage;
    public LayerMask TargetLayer => _targetLayer;
}
