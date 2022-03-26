using UnityEngine;

public class ActorRotation : MonoBehaviour
{
    protected IActorStats _actorStats;
    protected IActorController _actorController;

    protected void LookAtDirection(Vector3 direction)
    {
        var wantedDirection = Quaternion.LookRotation(direction, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, wantedDirection, _actorStats.RotationVelocity * Time.deltaTime);
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
