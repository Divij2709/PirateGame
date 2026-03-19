using UnityEngine;

public class Buff_Token : MonoBehaviour
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

/*
 * Could use layers and simply move the bird forward a layer so it moves over the pillars and nests
 *
 * Could also just remove the collider component on the bird so it moves through the pillars.
 *   -> Could instead emit a sphere cast to check for the things the bird could interact with, then if its a buff or token
 *      leave the collider but if its an environment asset like the pillar remove the hitbox.
 * -> Should last for like 10 seconds, could do this in a coroutine and do the sphere check every second to be more efficient
 * -> also maybe flash the sprite for some visual feedback so when the flashing ends the last spherecast was sent.
 */
