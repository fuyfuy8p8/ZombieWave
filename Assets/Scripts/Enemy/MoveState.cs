using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using static UnityEditor.Experimental.GraphView.GraphView;

public class MoveState : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private Transform _target;
    [SerializeField] private NavMeshAgent _agent;

    private void Update()
    {
        _agent.SetDestination(_target.position);
        _animator.SetBool("Run", true);
    }

    private void OnDisable()
    {
        _animator.SetBool("Run", false);
    }
}
