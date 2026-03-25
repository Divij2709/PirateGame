using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Divij
{
    public class Bird_Manager : MonoBehaviour
    {
        [SerializeField] public GameObject playerPrefab;
        [SerializeField] public Transform spawnPoint;

        [SerializeField] public int liveCount = 3;

        [SerializeField] private List<GameObject> lifeIcons = new List<GameObject>();

        private GameObject currentPlayer;

        private void Start()
        {
            SpawnPlayer();
            UpdateLivesUI();
        }

        public void PlayerDied()
        {
            Destroy(currentPlayer);

            liveCount--;

            UpdateLivesUI();

            if (liveCount > 0)
            {
                Invoke(nameof(SpawnPlayer), 1f);
            }
            else
            {
                Debug.Log("Game Over :(");

                //Put an event here in the future that shows a death screen and send them to the lobby 

            }
        }

        public void SpawnPlayer()
        {
            currentPlayer = Instantiate(playerPrefab, spawnPoint.position, Quaternion.identity);
        }

        void UpdateLivesUI()
        {
            for (int i = 0; i < lifeIcons.Count; i++)
            {
                lifeIcons[i].SetActive(i < liveCount);
            }
        }

        public void UpdateRespawnPoint(Transform newPoint)
        {
            spawnPoint = newPoint;
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