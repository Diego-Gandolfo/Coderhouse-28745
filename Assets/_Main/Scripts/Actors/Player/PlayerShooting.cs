using UnityEngine;

public class PlayerShooting : ActorShooting
{
    private void Update()
    {
        CheckShootingInput();
    }

    private void CheckShootingInput()
    {
        if ((Input.GetAxisRaw("Fire1") != 0) && (CanShoot))
        {
            Shoot();
        }
    }
}