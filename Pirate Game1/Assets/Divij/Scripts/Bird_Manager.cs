using Unity.VisualScripting;
using UnityEngine;

namespace Divij
{
    public class Bird_Manager : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            
        }
    
        // Update is called once per frame
        void Update()
        {
            
        }
    }
}



// Use an OnTrigger to  trigger the parrots death and respawn 

/*
 For the death it can be triggered by the pipe but rather put the collider check in update of the bird manager so its not reliant on the pipe
 to trigger the death event and whatnot 
Death()  --> OnTriggerEnter() for the hitbox
{
    Destroy the current game object the camera is following
    Call on the respawn script
}

Respawn()
{
    Instantiate the player character in the air, Maybe make them hover for a second while flashing to let the player know its about to start
}

RespawnPoint()
{
    Does a hitbox check to look see whether the area passed is a respawn zone (Will just set colliders for it)
    If it is a respawn zone -> Update the transform of the respawn position to it
}


*/