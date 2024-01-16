using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatalObjectController : MonoBehaviour
{
    public GameController gameController;

    //Unity calls OnTriggerEnter automatically when two colliders meet (and one of them is a trigger)
    private void OnTriggerEnter(Collider other)
    {
        //If the player enters the fatal object's trigger collider...
        //Tell the GameController to reset the game
        if (other.gameObject.tag == "Player")
        {
            gameController.ResetGame();
        }
    }
}
