using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Player _target;
    [SerializeField] private float _attackDistance;
    [SerializeField] private float distance;
    [SerializeField] private float _stopDistance;
    [SerializeField] private float _health;
    public float diis;

    private NavMeshAgent _agent;
    private Vector3 _targetPosition;
    private Animator _animator;

    public Player Target =>_target;
    public NavMeshAgent Agent =>_agent;

    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _animator = GetComponent<Animator>();
    }

    public void Init(Player target)
    {
        _target = target;
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;

        if (_health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
