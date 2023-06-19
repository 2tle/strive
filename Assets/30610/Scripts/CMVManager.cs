using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CMVManager : MonoBehaviour
{
    public Transform player; // 플레이어의 Transform
    public float cameraDistance = 5f; // 카메라와 플레이어 사이의 기본 거리
    public LayerMask obstacleLayer; // 벽 또는 장애물을 포함하는 레이어

    private CinemachineVirtualCamera virtualCamera; // Cinemachine 가상 카메라 컴포넌트

    private void Start()
    {
        //virtualCamera = GetComponent<CinemachineVirtualCamera>();
    }

    private void Update()
    {
        if (player == null)
            return;

        // 플레이어와 카메라 사이의 방향과 거리 계산
        Vector3 cameraDirection = transform.position - player.position;
        float currentDistance = cameraDirection.magnitude;

        // 플레이어와 카메라 사이에 장애물이 있는지 체크
        RaycastHit hit;
        if (Physics.Raycast(player.position, cameraDirection, out hit, currentDistance, obstacleLayer))
        {
            // 장애물이 있는 경우 카메라의 위치를 조정
            float adjustedDistance = Mathf.Clamp(hit.distance - 0.1f, 0f, currentDistance); // 장애물에서 약간 뒤로 밀어냄
            virtualCamera.m_Lens.OrthographicSize = adjustedDistance + cameraDistance;
        }
        else
        {
            // 장애물이 없는 경우 카메라의 거리를 초기 거리로 설정
            virtualCamera.m_Lens.OrthographicSize = cameraDistance;
        }
    }
}

