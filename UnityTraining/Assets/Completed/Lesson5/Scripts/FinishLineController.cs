using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineController : MonoBehaviour
{
    public GameController gameController;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>(); //Save a reference to the AudioSource
    }

    //Unity calls OnTriggerEnter automatically when two colliders meet (and one of them is a trigger)
    private void OnTriggerEnter(Collider other)
    {
        //If the player enters the finish line's trigger collider...
        //Play the sound, and tell the GameController to finish the game
        if (other.gameObject.tag == "Player")
        {
            audioSource.Play();
            gameController.FinishGame();

            //Turn this script off, so we don't keep recognising collisions and playing sounds
            enabled = false;
        }
    }
}
