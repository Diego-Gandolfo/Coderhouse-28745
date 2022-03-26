using UnityEngine;

public interface IBulletStats
{
    Bullet Prefab { get; }
    float Velocity { get; }
    float Damage { get; }
    LayerMask TargetLayer { get; }
}
