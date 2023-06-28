using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public float startTime;
    // Start is called before the first frame update
    void Start()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        if(currentSceneName == "Map2Scene")
        {
            startTime = Time.time;
            PlayerPrefs.SetFloat("StartTime", startTime);
        } else
        {
            startTime = PlayerPrefs.GetFloat("StartTime");
        }

    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.time - startTime;
        Debug.Log(time);
        UpdateTimerText(time);
        PlayerPrefs.SetFloat("PlayTime", time);

    }

    private void UpdateTimerText(float time)
    {
        int minutes = (int)(time / 60);
        int seconds = (int)(time % 60);
        string timeString = string.Format("{0:00}:{1:00}", minutes, seconds);
        timerText.text = timeString;
    }
}
