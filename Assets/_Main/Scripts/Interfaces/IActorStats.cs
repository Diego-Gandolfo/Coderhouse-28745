using UnityEngine;

public interface IActorStats
{
    float MovementVelocity { get; }
    float RotationVelocity { get; }
    float MaxHealth { get; }
}
