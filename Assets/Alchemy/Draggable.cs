using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Required Components
[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(SpriteRenderer))]

public class Draggable : MonoBehaviour
{
    // Variables
    private Vector2 mousePositionOffset;
    private SpriteRenderer spriteRenderer;

    // Functions
    private Vector2 GetMouseWorldPosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDown()
    {
        spriteRenderer.sortingOrder = 1;
        mousePositionOffset = (Vector2)transform.position - GetMouseWorldPosition();
    }
    
    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPosition() + mousePositionOffset;
    }

    private void OnMouseUp()
    {
        spriteRenderer.sortingOrder = 0;
    }

    private void Start()
    {
        // Get Components
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
}
