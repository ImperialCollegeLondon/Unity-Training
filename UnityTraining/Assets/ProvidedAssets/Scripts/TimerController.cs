using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerController : MonoBehaviour 
{
    public TMP_Text timeText; //A reference to the text UI object that will show the time on the screen
    private float timeOfGameStart;

    // Start is called before the first frame update
    void Start()
    {
        timeOfGameStart = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float secondsElapsed = Time.time - timeOfGameStart;
        timeText.text = FormatTime(secondsElapsed);
    }

    public void ResetTimer()
    {
        timeOfGameStart = Time.time;
    }

    public void StopTimer()
    {
        //"enabled" is a bool that all MonoBehaviour scripts have 
        //if false, Start and Update wont execute
        enabled = false;
        timeText.color = Color.green;
    }

    //Takes a float representing a number of seconds and returns it in a string formatted to MM:SS - Don't worry about this!
    private string FormatTime(float seconds)
    {
        TimeSpan timeSpan = TimeSpan.FromSeconds(seconds);
        return string.Format("{0:D2}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds);
    }
}
