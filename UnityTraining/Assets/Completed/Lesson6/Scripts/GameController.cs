using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public PlayerController playerController;
    public TimerController timerController;

    public TMP_Text scoreText; //A reference to the score text object on the UI that shows the score on the screen

    //A reference to not one PickupController, but any number of them, in a list
    public List<PickupController> pickups;

    private float score = 0;

    void Update()
    {
        //"Cancel" is the escape on a keyboard, or the 'B' button on a controller
        if (Input.GetButtonDown("Cancel")) 
        {
            //Only works in the final build of the .exe, so that's where we'll have to test it!
            Application.Quit();
        }
    }

    public void ResetGame()
    {
        timerController.ResetTimer();

        score = 0;
        scoreText.text = score.ToString();

        //Reset all the pickups 
        foreach (PickupController pickup in pickups)
        {
            pickup.ResetPickup();
        }

        playerController.Respawn();
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void FinishGame()
    {
        timerController.StopTimer();
    }
}
