using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotateSpeed;

    // Update is called once per frame
    void Update()
    {
        // Rotate the GameObject around the local Y-axis
        // We multiply our speed by Time.deltaTime (the time that's passed since the last Update)
        // If more time has passed since last update, we want to rotate further, so the rotation speed looks smooth
        // Space.self indicates we want to rotate around the local "up" vector, not the global up vector
        gameObject.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.Self);
    }
}
