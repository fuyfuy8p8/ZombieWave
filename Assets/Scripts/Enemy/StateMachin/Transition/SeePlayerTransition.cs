using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeePlayerTransition : MonoBehaviour
{
    [SerializeField] private float _visionDistance;
    [SerializeField] private Transform _target;
    [SerializeField] private MoveState _moveState;
    [SerializeField] private AttackState _attackState;

    private void Update()
    {
        if (_attackState.enabled==false)
        {
            if (Vector3.Distance(transform.position, _target.transform.position) <= _visionDistance &&
            _moveState.enabled == false)
            {
                _moveState.enabled = true;
            }
            else if (Vector3.Distance(transform.position, _target.transform.position) > _visionDistance &&
                _moveState.enabled == true)
            {
                _moveState.enabled = false;
            }
        }
        else
        {
            _moveState.enabled=false;
        }
    }
}
