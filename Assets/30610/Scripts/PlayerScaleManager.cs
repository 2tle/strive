using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScaleManager : MonoBehaviour
{
    public GameObject player;
    public Transform startPoint; // 구간 시작 지점
    public Transform endPoint; // 구간 종료 지점
    public float maxScale; // 최대 크기
    public float minScale; // 최소 크기

    private float initialScale; // 초기 크기

    private void Start()
    {
        initialScale = transform.localScale.x; // 현재 크기를 초기 크기로 설정
    }

    private void Update()
    {
        float distance = Vector3.Distance(player.transform.position, startPoint.position); // 시작 지점으로부터의 거리 계산
        float totalDistance = Vector3.Distance(startPoint.position, endPoint.position); // 구간 전체 길이 계산

        // 거리에 따라 크기 설정
        if (distance <= totalDistance)
        {
            float t = distance / totalDistance; // 보간에 사용할 거리 비율 계산
            float currentScale = Mathf.Lerp(initialScale, maxScale, t); // 현재 크기 계산

            player.transform.localScale = new Vector3(currentScale, currentScale, currentScale); // 크기 적용
        }
        else
        {
            player.transform.localScale = new Vector3(initialScale, initialScale, initialScale); // 초기 크기로 복원
        }
    }

}
