using UnityEngine;

[CreateAssetMenu(fileName = "New_ActorStats", menuName = "Flyweight/Stats/Actor", order = 0)]
public class ActorStats : ScriptableObject, IActorStats
{
    [SerializeField] private float _movementVelocity = 10.0f;
    [SerializeField] private float _rotationVelocity = 10.0f;
    [SerializeField] private float _maxHealth;

    public float MovementVelocity => _movementVelocity;
    public float RotationVelocity => _rotationVelocity;
    public float MaxHealth => _maxHealth;
}
