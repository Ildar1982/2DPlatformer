using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(MoverPlayer))]

public class Hero : MonoBehaviour
{
    private MoverPlayer _mover;

    private void Start()
    {
        _mover = GetComponent<MoverPlayer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent(out ObstacleUp obstacleUP) || collision.collider.TryGetComponent(out Ground ground))
        {
            _mover.AllowJump();
        }
        if (collision.collider.TryGetComponent(out Money money))
        {            
            Destroy(money.gameObject);
        }
    }
}
