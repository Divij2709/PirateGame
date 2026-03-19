using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Fly_Behaviour : MonoBehaviour
{
    [SerializeField] public float flySpeed = 2f;

    private Rigidbody2D rb;

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Debug.Log("Mouse Pressed");
            rb.linearVelocity = Vector2.up * flySpeed;
        }
    }
}
