using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(CharacterController))]

public class RotateTurrel : MonoBehaviour
{
    [SerializeField] private float turnSpeed;
    [SerializeField] private float moveSpeed;
    [SerializeField] private CharacterController _characterController;

    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    /*
    public void MoveCharacter(Vector3 moveDirection)
    {
        moveDirection = moveDirection * moveSpeed;
        _characterController.Move(moveDirection * Time.deltaTime);
    }
    */

    public void RotateCharacter(Vector3 moveDirection)
    {

        if (Vector3.Angle(transform.forward, moveDirection) > 0)
        {
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, moveDirection, turnSpeed, 0);
            transform.rotation = Quaternion.LookRotation(newDirection);
        }
    }

}
