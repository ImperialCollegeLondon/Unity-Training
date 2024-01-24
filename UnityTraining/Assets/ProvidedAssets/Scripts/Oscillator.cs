using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    public float oscillateAmplitude;
    public float oscillateSpeed;
    public float oscillateOffset; 

    private Vector3 initialPos;

    void Start()
    {
        //Save the position of the GameObject when we start
        initialPos = gameObject.transform.position;
    }

    void Update()
    {
        //We want to bob up and down along the GameObject's up vector
        //To achieve a bobbing effect, we can use a sine wave! As x increases, y will oscillate 
        //So we need a variable for x that will increase with time, how about... time!!
        //We also add an offset, so we can vary different instances of this wave within our scene
        //This way, not everything reaches the peak of the wave at the exact same time
        //Multiplying by our oscillate speed is like making the sine graph's x variable change faster, increasing the frequency of the wave
        float sineWaveX = (Time.time + oscillateOffset) * oscillateSpeed;

        //Plugging our X value into the Mathf.Sin function turns gives us the value of the sine wave at the X value
        //Multiplying THAT by transform.up (0, 1, 0) gives us a vector up/down of oscillilating magnitude 
        //Adding that oscilliating vector onto the GameObject's start position makes it bop up and down along it's y axis 
        gameObject.transform.position = initialPos + (gameObject.transform.up * Mathf.Sin(sineWaveX) * oscillateAmplitude);
    }
}
