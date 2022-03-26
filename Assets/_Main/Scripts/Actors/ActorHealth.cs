using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ActorHealth : MonoBehaviour
{
    private IActorStats _actorStats;
    private float _currentHealth;

    public event Action OnDie;

    protected virtual void Start()
    {
        _currentHealth = _actorStats.MaxHealth;
    }

    protected abstract void Die();

    public void RecieveDamage(float damage)
    {
        if (damage <= 0) return;

        _currentHealth -= damage;

        if (_currentHealth <= 0)
        {
            _currentHealth = 0;
            OnDie?.Invoke();
        }
    }

    public void SetActorStats(IActorStats actorStats)
    {
        _actorStats = actorStats;
    }
}
