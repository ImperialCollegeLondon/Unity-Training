using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform ballToFollow;
    private Vector3 cameraOffset;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start!");

        //Get the vector from the ball to the camera
        cameraOffset = transform.position - ballToFollow.position;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");

        //Set the position of the camera equal to the ball, PLUS the offset vector we found at the start
        //This means the camera will always stay in the same position, relative to the ball
        transform.position = ballToFollow.position + cameraOffset;
    }
}
