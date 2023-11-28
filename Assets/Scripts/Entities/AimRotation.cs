using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer armRenderer;
    [SerializeField] private Transform armPivot;

    [SerializeField] private SpriteRenderer characterRenderer;

    private CharacterController controller;


    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }


    void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnAim(Vector2 newAimDirection)
    {
        RotateArm(newAimDirection);
    }

    public void RotateArm(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        armRenderer.flipY = Mathf.Abs(rotZ) > 90f;
        characterRenderer.flipX = armRenderer.flipY;
        armPivot.rotation = Quaternion.Euler(0, 0, rotZ);
    }
}
