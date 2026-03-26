using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public static bool gameStarted = false;

    [SerializeField] private GameObject StartOverlay;

    private void Start()
    {
        Time.timeScale = 0f;
        gameStarted = false;
        StartOverlay.SetActive(true);
    }

    private void Update()
    {
        if (!gameStarted && Mouse.current.rightButton.wasPressedThisFrame)
        {
            StartGame();
        }
    }

    public void StartGame()
    {
        gameStarted = true;
        Time.timeScale = 1f;
        
        StartOverlay.SetActive(false);
    }
}
