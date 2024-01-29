/*
 *  MOVEMENT SYSTEM 2
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMovement : MonoBehaviour
{
    [Tooltip("True if character should only move in whole units on the grid.\nFalse if character has free movement to roam on grid.")]
    [SerializeField] protected bool constrainToGridUnits = false;
    
    private Vector2 CartesianToIsometricCoord(Vector2 cartesianCoord) {
        Vector2 isoCoord = new Vector2(
            //Isometric X coordinate calc.
            cartesianCoord.x - cartesianCoord.y,
            //Isometric Y coordinate calc.
            (cartesianCoord.x + cartesianCoord.y) / 2);

        return isoCoord;
    }

    public void Move(Vector2 direction) {
        direction = CartesianToIsometricCoord(direction);
        transform.position += (Vector3)direction;
    }
}
