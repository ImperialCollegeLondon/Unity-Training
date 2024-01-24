using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatalObjectController : MonoBehaviour
{
    public GameController gameController;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>(); //Save a reference to the AudioSource
    }

    //Unity calls OnCollisionEnter automatically when two colliders meet (when neither are trigger, and one has a RigidBody)
    private void OnCollisionEnter(Collision coll)
    {
        //If the player enters the fatal object's trigger collider...
        //Play the sound, and tell the GameController to reset the game
        if (coll.gameObject.tag == "Player")
        {
            audioSource.Play();
            gameController.ResetGame();
        }
    }
}
