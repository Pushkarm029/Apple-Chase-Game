using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        float t = Time.time - startTime;
        int minVal = Mathf.FloorToInt((int)t / 60);
        string minutes = minVal.ToString();
        int minSec = Mathf.FloorToInt((int)t % 60);
        string seconds = minSec.ToString("0");
        timerText.text = minutes + ":" + seconds;
    }
}
