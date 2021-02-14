using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MoverPlayer))]

public class InputPlayer : MonoBehaviour
{
    private MoverPlayer _mover;

    private void Start()
    {
        _mover = GetComponent<MoverPlayer>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _mover.MoveLeft();
        }
        if (Input.GetKey(KeyCode.D))
        {
            _mover.MoveRight();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _mover.Jamp();
        }
    }
}
