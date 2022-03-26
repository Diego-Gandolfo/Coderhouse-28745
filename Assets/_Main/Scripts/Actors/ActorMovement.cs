using UnityEngine;

public abstract class ActorMovement : MonoBehaviour
{
    private IActorStats _actorStats;
    private IActorController _actorController;

    protected void Movement(Vector3 direction)
    {
        _actorController.Rigidbody.velocity = (direction * _actorStats.MovementVelocity);
    }

    public void SetActorStats(IActorStats actorStats)
    {
        _actorStats = actorStats;
    }

    public void SetActorController(IActorController actorController)
    {
        _actorController = actorController;
    }
}
