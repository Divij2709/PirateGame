using System;
using UnityEngine;

namespace Divij
{
    public class Pipe_Movement : MonoBehaviour
    {
        [SerializeField] public float pipeMoveSpeed = 10f;
        
    
        public void Update()
        {
            if (!GameManager.gameStarted) return;
            
            transform.position += Vector3.left * pipeMoveSpeed * Time.deltaTime;
        }
    }
}


