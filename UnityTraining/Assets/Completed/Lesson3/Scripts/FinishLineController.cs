using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineController : MonoBehaviour
{
    private bool hasFinished = false;

    //Unity calls OnTriggerEnter automatically when two colliders meet (and one of them is a trigger)
    private void OnTriggerEnter(Collider coll)
    {
        //If the player enters the finish line's trigger collider (and it hasn't before)
        //tell the GameController to finish the game
        if (coll.gameObject.tag == "Player" && !hasFinished)
        {
            Debug.Log("Player collided with the finish line!");

            //Set our boolean to true so we don't fall into this code again
            hasFinished = true;
        }
    }
}
