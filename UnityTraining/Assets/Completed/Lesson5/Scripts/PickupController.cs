using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour
{
    public GameController gameController;

    private Renderer renderer;
    private Light light;

    private bool pickedUp = false;

    // Start is called before the first frame update
    void Start()
    {
        renderer = gameObject.GetComponent<Renderer>(); //Save a reference to the renderer!
        light = gameObject.GetComponent<Light>(); //And for the light I've also added to the pickup GameObject
    }

    //Unity calls OnTriggerEnter automatically when two colliders meet (and one of them is a trigger)
    private void OnTriggerEnter(Collider coll)
    {
        //If the player enters the pickup's trigger collider, and the pickup hasn't been picked-up
        //Tell the GameController to give us score, and make the pickup dissapear
        if (coll.gameObject.tag == "Player" && !pickedUp)
        {
            gameController.IncreaseScore();

            //Can't just set the pickup GameObject to inactive, as that will stop the audiosource we'll be adding later on!
            renderer.enabled = false; //Hides the gameobject
            light.enabled = false; //Make the light dissapear too!

            pickedUp = true; //So we don't register the collision again until we reset
        }
    }

    public void ResetPickup()
    {
        renderer.enabled = true; //Turn the renderer back on
        light.enabled = true; //Turn the light back on too

        pickedUp = false; //So we register collisions with the player
    }
}
