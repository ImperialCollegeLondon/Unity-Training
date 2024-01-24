using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rigidbody;

    public float moveForce;  
    private float horizontalInput;
    private float verticalInput;

    public float jumpForce;
    public LayerMask groundLayer;

    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
        startPosition = gameObject.transform.position;
    }

    //Reading player input in update
    void Update()
    {
        //These refer to the arrow keys, or the WASD keys on a keyboard, or the thumbstick on a controller
        horizontalInput = Input.GetAxis("Horizontal"); 
        verticalInput = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Jump") && IsGrounded()) //"Jump" is the spacebar on a keyboard, or the 'A' button on a controller
        {
            Jump();         
        }
    }

    void FixedUpdate()
    {
        //Apply a continuous horizontal force for rolling the ball
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);
        rigidbody.AddForce(movement * moveForce, ForceMode.Force);
    }
    
    void Jump()
    {
        // Apply an immediate vertical force for jumping
        rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    public void Respawn()
    {
        //Move the GameObject back to where it started, and cancel all velocity 
        gameObject.transform.position = startPosition;
        rigidbody.velocity = Vector3.zero;
        rigidbody.angularVelocity = Vector3.zero;
    }

    // Check if the player is grounded (we should only be able to jump if we are touching the ground)
    public bool IsGrounded()
    {
        //Assuming the ball is a sphere, if it has a lossyScale of 1, it's size will be (1, 1, 1), meaning its radius is 0.5
        float collisionCheckRadius = (transform.lossyScale.magnitude / 2) + 0.1f; //Slightly larger than the ball

        //Do a raycast from the center of the ball, straight down, at a distance slightly larger than the radius of the ball
        //the last parameter is the layermask, which tells the Raycast which layers to recognise collisions with
        return Physics.Raycast(transform.position, Vector3.down, collisionCheckRadius, groundLayer);
    }
}
