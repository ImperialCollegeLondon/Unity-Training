using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public PlayerController playerController;
    public TimerController timerController;

    public void ResetGame()
    {
        timerController.ResetTimer();

        playerController.Respawn();
    }

    public void FinishGame()
    {
        timerController.StopTimer();
    }
}
