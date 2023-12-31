using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private CharacterController controller;

    private Vector2 movementDirection = Vector2.zero;
    private Rigidbody2D rigidbody;
    
    [SerializeField] private Animator animator;
    //[SerializeField] private List<Animator> animators;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        rigidbody = GetComponent<Rigidbody2D>();
        animator = transform.Find("MainSprite").GetComponent<Animator>();
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
        direction = direction * 10;
        rigidbody.velocity = direction;
        //animators[(int)GameManager.instance.CurCharacter].SetFloat("Speed", direction.normalized.magnitude);
        animator.SetFloat("Speed", direction.normalized.magnitude);
        
    }


}
