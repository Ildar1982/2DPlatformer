using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPlayer : MonoBehaviour
{
    private float _sizeStepStandart = 2;
    private float _jampStep = 3;
    private float _jampHeigth = 1;
    private bool _jampInit = false;
    private bool _move = false;
    private bool permissionToJump = false;
    private int _directions;
    private float _sizeStep;
    private float _jampTime = 0;
    private Rigidbody2D _rigid;
    private Animator _animator;
    private Hero _hero;

    private void Start()
    {
        _rigid = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _hero = GetComponent<Hero>();
    }

    private void Update()
    {
        if (_jampInit == true)
        {
            _rigid.AddForce(Vector2.up * _jampStep);
            _animator.SetBool("Jamp", true);
            _jampTime += Time.deltaTime;
            if (_jampTime >= _jampHeigth)
            {
                _jampInit = false;
                _animator.SetBool("Jamp", false);
                _jampTime = 0;
            }
        }
        if (_move == true)
        {
            _rigid.AddForce(Vector2.right * _sizeStep);
            _move = false;
        }
    }

    public void MoveLeft()
    {
        _directions = -1;
        MoveParametrs(_directions);
    }

    public void MoveRight()
    {
        _directions = 1;
        MoveParametrs(_directions);
    }

    public void Jamp()
    {
        if (permissionToJump == true)
        {
            _jampInit = true;
            permissionToJump = false;
        }
    }

    private void MoveParametrs(int directions)
    {
        _sizeStep = _sizeStepStandart;
        _sizeStep *= directions;
        _move = true;
    }

    public void AllowJump()
    {
        permissionToJump = true;
    }
}
