using UnityEngine;

public abstract class ActorRotation : MonoBehaviour
{
    private IActorStats _actorStats;

    protected void LookAtDirection(Vector3 direction)
    {
        var wantedDirection = Quaternion.LookRotation(direction, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, wantedDirection, _actorStats.RotationVelocity * Time.deltaTime);
    }

    public void SetActorStats(IActorStats actorStats)
    {
        _actorStats = actorStats;
    }
}
