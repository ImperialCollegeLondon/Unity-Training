using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineController : MonoBehaviour
{
    public GameController gameController;

    //Unity calls OnTriggerEnter automatically when two colliders meet (and one of them is a trigger)
    private void OnTriggerEnter(Collider other)
    {
        //If the player enters the finish line's trigger collider...
        //tell the GameController to finish the game
        if (other.gameObject.tag == "Player")
        {
            gameController.FinishGame();

            //Turn this script off, so we don't keep recognising collisions and playing sounds
            enabled = false;
        }
    }
}
