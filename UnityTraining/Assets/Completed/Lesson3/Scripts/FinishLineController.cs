using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineController : MonoBehaviour
{
    //Unity calls OnTriggerEnter automatically when two colliders meet (and one of them is a trigger)
    private void OnTriggerEnter(Collider coll)
    {
        //If the player enters the finish line's trigger collider...
        //tell the GameController to finish the game
        if (coll.gameObject.tag == "Player")
        {
            Debug.Log("Player collided with the finish line!");
        }
    }
}
