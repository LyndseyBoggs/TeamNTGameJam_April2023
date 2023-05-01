using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 10;
    [SerializeField] float rotationSpeed = 360;
    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }
    

    public void Look(Vector3 directionalInput)
    {
        Debug.Log(directionalInput);
        if (directionalInput == Vector3.zero) return;

        var lookDirection = (transform.position + directionalInput) - transform.position;
        var newRotation = Quaternion.LookRotation(Vector3.forward,lookDirection);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, newRotation,rotationSpeed);
    }

    public void Move()
    {
        var newPosition = transform.position + transform.up * speed * Time.deltaTime;
        rb.MovePosition(newPosition);
        Debug.Log("Moving");
    }
}
