using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] Bumper bumper1;
    [SerializeField] Bumper bumper2;
    [SerializeField] float moveSpeed;
    InputActions inputActions;

    private void Awake()
    {
        if(inputActions == null)
        {
            inputActions = new InputActions();
        }
    }

    private void OnEnable()
    {
        if(inputActions != null)
        {
            inputActions.Enable();
        }
    }
    private void OnDisable()
    {
        if(inputActions != null)
        {
            inputActions.Disable();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        inputActions.PlayerOne.Move.performed += MoveUpPlayerOneUpdate;
        inputActions.PlayerOne.Move.canceled += MoveUpPlayerOneUpdate;

        inputActions.PlayerTwo.Move.performed += MoveUpPlayerTwoUpdate;
        inputActions.PlayerTwo.Move.canceled += MoveUpPlayerTwoUpdate;

    }

    private void MoveUpPlayerOneUpdate(InputAction.CallbackContext obj)
    {
        bumper1.Move(obj.ReadValue<float>());
    }
    private void MoveUpPlayerTwoUpdate(InputAction.CallbackContext obj)
    {
        bumper2.Move(obj.ReadValue<float>());
        //when ball hits a collider, send the directional value from redirectball script to the ball
    }

}
