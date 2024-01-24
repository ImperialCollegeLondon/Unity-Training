using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatalObjectController : MonoBehaviour
{
    public GameController gameController;

    //Unity calls OnCollisionEnter automatically when two colliders meet (when neither are trigger, and one has a RigidBody)
    private void OnCollisionEnter(Collision coll)
    {
        //If the player enters the fatal object's trigger collider...
        //Tell the GameController to reset the game
        if (coll.gameObject.tag == "Player")
        {
            gameController.ResetGame();
        }
    }
}
