using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Animator))]
public class IdleState : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private NavMeshAgent _agent;

    private void Update()
    {
        _animator.SetBool("Run", false);
        _animator.SetBool("Attack", false);
    }
}
