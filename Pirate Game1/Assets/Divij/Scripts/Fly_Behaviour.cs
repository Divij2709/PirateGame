using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Divij
{
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

        public void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Pipe"))
            {
                //FindObjectsByType<Bird_Manager>().PlayerDied();
                Debug.Log("Death");
            }
        }
    }
}

/*
 Might move t bird manager for SRP (Dont know if uts necessary cause theyre still managing seperate things) 
 -> Would like to add the birds animation such that on mouse press the animation triggers. (Need to read up more on animation transitions)

*/