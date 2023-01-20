using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyJoystick : MyJoysticSettings
{
    [SerializeField] private RotateTurrel RotateTurrel;

    void Update()
    {
        if (_inputVector.x != 0 || _inputVector.y != 0)
        {
            //RotateTurrel.MoveCharacter(new Vector3(_inputVector.x, -_inputVector.y, 1));
            RotateTurrel.RotateCharacter(new Vector3(-_inputVector.x, _inputVector.y, -1));
        }
        else
        {
            //RotateTurrel.MoveCharacter(new Vector3(Input.GetAxis("Horizontal"), 0, (Input.GetAxis("Vertical"))));
            RotateTurrel.RotateCharacter(new Vector3(Input.GetAxis("Horizontal"), 0, (Input.GetAxis("Vertical"))));

        }
    }
}
