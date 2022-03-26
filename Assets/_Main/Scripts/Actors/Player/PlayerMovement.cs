using UnityEngine;

public class PlayerMovement : ActorMovement
{
    private void Update()
    {
        var move = CheckMovementInput();
        Movement(move);
    }

    private Vector3 CheckMovementInput()
    {
        var move = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical")).normalized;
        return move;
    }
}
