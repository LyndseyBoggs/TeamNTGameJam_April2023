using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    PlayerMovement playerMovement;
    PlayerInputs inputs;

    Vector2 desiredMovement;

    private void Awake()
    {
        inputs = new PlayerInputs();
        playerMovement = GetComponent<PlayerMovement>();
    }
    private void OnEnable()
    {
        inputs.Enable();
        inputs.Movement.Move.performed += OnMovePerformed;
        inputs.Movement.Move.canceled += OnMoveCanceled;
    }

    private void OnDisable()
    {
        inputs.Disable();
        inputs.Movement.Move.performed -= OnMovePerformed;
        inputs.Movement.Move.canceled -= OnMoveCanceled;
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void OnMovePerformed(InputAction.CallbackContext context)
    {
        desiredMovement = context.ReadValue<Vector2>();
    }

    void OnMoveCanceled(InputAction.CallbackContext context)
    {
        desiredMovement = Vector2.zero;
    }

    void MovePlayer()
    {
        if (desiredMovement == Vector2.zero) return;

        playerMovement.Look(desiredMovement);
        playerMovement.Move();
    }
}
