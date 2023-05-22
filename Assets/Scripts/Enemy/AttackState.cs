using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AttackState : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private float _delay;
    [SerializeField] private Health _playerHealth;
    [SerializeField] private CapsuleCollider _attackTrigger;

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        _animator.SetBool("Attack", true);
    }

    private void OnDisable()
    {
        _animator.SetBool("Attack", false);
    }

    private void OnAttack()
    {
        _attackTrigger.enabled = true;
    }
}
