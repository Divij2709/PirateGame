/*using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Pirate_Controller : MonoBehaviour
{
    [SerializeField] private float jumpForce = 5f;

    private Rigidbody2D rb;
    private Transform currentRope;
    private bool isAttached = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            if (isAttached)
            {
                JumpOffRope();
            }
        }
    }

    private void FixedUpdate()
    {
        if (isAttached && currentRope != null)
        {
            transform.position = currentRope.position;
        }
    }

    private void JumpOffRope()
    {
        isAttached = false;
        rb.bodyType = RigidbodyType2D.Dynamic;

        Vector2 direction = transform.up;
        rb.linearVelocity = direction * jumpForce;

        currentRope = null;
        
    }

    private void OnTriggerEnter(Collider2D collision)
    {
        if (collision.CompareTag("Rope"))
        {
            AttachToRope(collision.transform);
        }
    }

    private void AttachToRope(Transform rope)
    {
        isAttached = true;
        currentRope = rope;
        
        rb.linearVelocity = Vector2.zero;
        rb.bodyType = RigidbodyType2D.Kinematic;
    }
}
*/