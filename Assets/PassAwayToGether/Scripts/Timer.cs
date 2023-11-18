using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float currentTime=0;
    public bool toContinue=true;
    private int minutes;
    private int seconds;
    private string t;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (toContinue == true)
        {
            currentTime += Time.deltaTime;
            countingTime(currentTime);
        }
    }
    public void countingTime(float currentT)
    {
        
        minutes = Mathf.FloorToInt(currentT / 60F);
        seconds = Mathf.FloorToInt(currentT - minutes * 60);
        t = string.Format("{0:00}:{1:00}", minutes, seconds);
        timerText.text = t;
        if (minutes == 1)
        {
            toContinue = false;

        }
    }

    
}

