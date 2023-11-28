using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private CharacterController controller;

    private Vector2 movementDirection = Vector2.zero;
    private Rigidbody2D rigidbody;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }


    // -----------------------------------------------------

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;

        rigidbody.velocity = direction;
    }


}
