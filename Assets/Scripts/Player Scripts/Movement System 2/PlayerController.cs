/*
 *  MOVEMENT SYSTEM 2
 *  
 *  TODO: Convert to Unity Input System
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : CharacterController_Base
{
    void Update()
    {
        HandleMovementInput();
    }

    private void HandleMovementInput() {
        
        Vector2 direction = new Vector2();

        //Up (W)
        if (Input.GetKey(KeyCode.W)) {
            direction += new Vector2(0, 1);
        }

        //Down (S)
        if (Input.GetKey(KeyCode.S)) {
            direction += new Vector2(0, -1);
        }

        //Left (A)
        if (Input.GetKey(KeyCode.A)) {
            direction += new Vector2(-1, 0);
        }

        //Right (D)
        if (Input.GetKey(KeyCode.D)) {
            direction += new Vector2(1, 0);
        }

        Motion = direction.normalized * Speed * Time.deltaTime;
        CharGridMovement.Move(Motion);
    }
}
