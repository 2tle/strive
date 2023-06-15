using UnityEngine;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour
{
    public Text timeText; // 텍스트를 표시할 UI 요소(Text 컴포넌트)

    private float elapsedTime; // 경과 시간을 저장할 변수

    private void Start()
    {
        elapsedTime = 0f; // 경과 시간 초기화
    }

    private void Update()
    {
        elapsedTime += Time.deltaTime; // 경과 시간 갱신

        // 경과 시간을 분:초 형식의 텍스트로 변환하여 UI 요소에 표시
        int minutes = Mathf.FloorToInt(elapsedTime / 60f);
        int seconds = Mathf.FloorToInt(elapsedTime % 60f);
        string timeString = string.Format("{0:00}:{1:00}", minutes, seconds);
        timeText.text = "Time: " + timeString;
    }
}