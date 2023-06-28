using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTime : MonoBehaviour
{

    public Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        UpdateTimerText(PlayerPrefs.GetFloat("PlayTime"));
    
    }

    private void UpdateTimerText(float time)
    {
        int minutes = (int)(time / 60);
        int seconds = (int)(time % 60);
        string timeString = string.Format("{0:00}:{1:00}", minutes, seconds);
        timerText.text = timeString;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
