using System;
using Divij;
using UnityEngine;

namespace Divij
{
   public class RespawnPoint : MonoBehaviour
   {
       private void OnTriggerEnter2D(Collider2D collision)
       {
           if (collision.CompareTag("Player"))
           {
              // FindObjectsByType<Bird_Manager>().UpdateRespawnPoint(transform);
              
              Debug.Log("Respawn Set");
           }
       }
   } 
}

