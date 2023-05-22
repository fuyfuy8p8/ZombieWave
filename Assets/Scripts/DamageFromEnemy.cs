using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageFromEnemy : MonoBehaviour
{
    [SerializeField] private int _damage;
    private Health _playerHealth;
    [SerializeField] private CapsuleCollider _attackTrigger;

    private void OnTriggerEnter(Collider other)
    {
        _playerHealth= other.gameObject.GetComponentInChildren<Health>();

        if (_playerHealth!=null)
        {
            _playerHealth.GetDamage(_damage);
        }

        _attackTrigger.enabled =false;
    }
}
