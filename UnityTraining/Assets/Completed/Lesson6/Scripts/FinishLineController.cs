using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineController : MonoBehaviour
{
    public GameController gameController;
    private AudioSource audioSource;

    private bool hasFinished = false;

    private void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>(); //Save a reference to the AudioSource
    }

    //Unity calls OnTriggerEnter automatically when two colliders meet (and one of them is a trigger)
    private void OnTriggerEnter(Collider coll)
    {
        //If the player enters the finish line's trigger collider (and it hasn't before)
        //Play the sound, and tell the GameController to finish the game
        if (coll.gameObject.tag == "Player" && !hasFinished)
        {
            audioSource.Play();
            gameController.FinishGame();

            //Set our boolean to true so we don't fall into this code again
            hasFinished = true;
        }
    }
}
