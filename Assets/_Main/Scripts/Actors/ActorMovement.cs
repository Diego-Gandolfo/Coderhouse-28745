using UnityEngine;

public class ActorMovement : MonoBehaviour
{
    protected IActorStats _actorStats;
    protected IActorController _actorController;

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
