using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController _controller;
    private Animator _animator;
    private float _horizontal;
    private float _vertical;
    private bool _inMove =false;
    private  int _animatorParamRun = Animator.StringToHash("Run");
    private int _animatorParamAttack = Animator.StringToHash("Attack");

    private void Start()
    {
        _controller = GetComponent<CharacterController>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");
        TryAttack();
        Vector3 moveDirection = new Vector3(_horizontal, 0f, _vertical);

        Move(moveDirection);
    }

    private void Move(Vector3 moveDirection)
    {
        if (moveDirection.magnitude > 0 && !_inMove)
        {
            _animator.SetBool(_animatorParamRun, true);
            _inMove = true;
        }
        else if(moveDirection.magnitude == 0 && _inMove)
        {
            _animator.SetBool(_animatorParamRun, false);
            _inMove = false;
        }
    }

    private void TryAttack()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _animator.SetTrigger(_animatorParamAttack);
        }
    }
}
