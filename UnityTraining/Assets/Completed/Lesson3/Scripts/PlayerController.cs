using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Making these public for now so we can see the values change in the inspector while in play mode
    public float horizontalInput;
    public float verticalInput;

    //Reading player input in update
    void Update()
    {
        //These refer to the arrow keys, or the WASD keys on a keyboard, or the thumbstick on a controller
        horizontalInput = Input.GetAxis("Horizontal"); 
        verticalInput = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Jump")) //"Jump" is the spacebar on a keyboard, or the 'A' button on a controller
        {
            Debug.Log("Jump!!");     
        }
    }
}
