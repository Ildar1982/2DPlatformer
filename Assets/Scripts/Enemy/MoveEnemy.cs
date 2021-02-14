using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]

public class MoveEnemy : MonoBehaviour
{
    private Rigidbody2D _rigid;
    private Animator _animator;
    private float _sizeStep = 2;
    private float _oneWayPassageTime = 3;
    private float _passageTime = 0;

    private void Start()
    {
        _rigid = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _rigid.AddForce(Vector2.right * _sizeStep);
        _passageTime += Time.deltaTime;
        if (_passageTime > _oneWayPassageTime)
        {
            _sizeStep *= -1;
            _passageTime = 0;
            _animator.SetFloat("turnAround", _sizeStep);
            _oneWayPassageTime = Random.Range(1f, 6f);
        }
    }
}
