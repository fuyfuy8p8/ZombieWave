using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanseTransition : MonoBehaviour
{
    [SerializeField] private float _attackRange;
    [SerializeField] private float _rangetSpread;
    [SerializeField] private Transform _target;
    [SerializeField] private AttackState _attackState;

    private void Update()
    {
        if (Vector3.Distance(transform.position, _target.position) < _attackRange && _attackState.enabled == false)
        {
            _attackState.enabled = true;
        }
        else if(Vector3.Distance(transform.position, _target.position) > _attackRange && _attackState.enabled == true)
        {
            _attackState.enabled = false;
        }
    }
}
