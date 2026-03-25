using System;
using Divij;
using UnityEngine;

namespace Divij
{
   public class RespawnPoint : MonoBehaviour
   {
      [SerializeField] private Bird_Manager manager;
       private void Start()
       {
           manager = FindObjectOfType<Bird_Manager>();

       }

       private void OnTriggerEnter2D(Collider2D collision)
       {
           if (collision.CompareTag("Player"))
           {
               manager.UpdateRespawnPoint(transform);
              
              Debug.Log("Respawn Set");
           }
       }
   } 
}

