/*
 *  MOVEMENT SYSTEM 1 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputManager : MonoBehaviour
{
    PlayerMovement playerMovement;
    PlayerInputs inputs;

    Vector2 desiredMovement;
    private bool isCharSheetDisplayed = false;

    private void Awake()
    {
        inputs = new PlayerInputs();
        playerMovement = GetComponent<PlayerMovement>();
    }
    private void OnEnable()
    {
        inputs.Enable();
        inputs.GeneralInput.Move.performed += OnMovePerformed;
        inputs.GeneralInput.Move.canceled += OnMoveCanceled;
        inputs.GeneralInput.ToggleCharacterSheet.performed += OnToggleCharacterSheetPerformed;
    }

    private void OnDisable()
    {
        inputs.Disable();
        inputs.GeneralInput.Move.performed -= OnMovePerformed;
        inputs.GeneralInput.Move.canceled -= OnMoveCanceled;
        inputs.GeneralInput.ToggleCharacterSheet.performed -= OnToggleCharacterSheetPerformed;
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

    void OnToggleCharacterSheetPerformed(InputAction.CallbackContext context)
    {
        if (UIManager.Instance == null) return;

        UIManager.Instance.ToggleCharacterSheet(!isCharSheetDisplayed);
        isCharSheetDisplayed = !isCharSheetDisplayed;
    }

    void MovePlayer()
    {
        if (desiredMovement == Vector2.zero) return;

        playerMovement.Look(desiredMovement);
        playerMovement.Move();
    }
}
