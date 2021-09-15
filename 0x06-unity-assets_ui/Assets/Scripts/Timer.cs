using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour
{
    private float timez;
    public Text TimerText;
    private TimeSpan playTime;

    void Update()
    {
        timez = Time.time;
        playTime = TimeSpan.FromSeconds(timez);
        string timeStr = playTime.ToString("m':'ss'.'ff");
        TimerText.text = timeStr;
    }
}
