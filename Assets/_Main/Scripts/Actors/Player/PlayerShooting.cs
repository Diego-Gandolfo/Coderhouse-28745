using System.Collections;
using UnityEngine;

public class PlayerShooting : ActorShooting
{
    [SerializeField] private float _cooldown;

    private bool _canShoot;

    private void Start()
    {
        _canShoot = true;
    }

    private void Update()
    {
        CheckShootingInput();
    }

    private void CheckShootingInput()
    {
        if ((Input.GetAxisRaw("Fire1") != 0) && (_canShoot))
        {
            _canShoot = false;
            Shoot();
            StartCoroutine(CooldownTimer(_cooldown));
        }
    }

    IEnumerator CooldownTimer(float time)
    {
        yield return new WaitForSeconds(time);
        _canShoot = true;
    }
}
