/*
 *  MOVEMENT SYSTEM 2
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterController_Base : MonoBehaviour
{
    [SerializeField] protected GridMovement CharGridMovement;    
    [SerializeField] protected float Speed = 1.5f;
    protected Vector2 Motion;
}
