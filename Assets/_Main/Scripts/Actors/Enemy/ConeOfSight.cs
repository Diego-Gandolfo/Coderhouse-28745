using System;
using UnityEngine;

public class ConeOfSight : MonoBehaviour, IConeOfSight
{
    [SerializeField] private LayerMask _layerMask;

    public event Action OnSight;

    private void OnTriggerStay(Collider other)
    {
        if ((_layerMask & 1 << other.gameObject.layer) != 0)
        {
            OnSight?.Invoke();
        }
    }
}
