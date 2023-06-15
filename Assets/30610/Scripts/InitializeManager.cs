using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class InitializeManager : MonoBehaviour
{
    public Vector3 charSpawnPoint;
    public Vector3 objScale;
    public CinemachineVirtualCamera vCam;

    public float cameraDistance = 10f;
    public Vector3 cameraOffset = new Vector3(0f, 5f, -5f);

    public GameObject player;

    public float mouseSensitivity = 2f;
    private Vector2 rotation = Vector2.zero;


    // Start is called before the first frame update
    void Start()
    {
        GameObject playerPrefab = LobbyCharacterManager.getPlayerCharacterPrefab();
        player = Instantiate(playerPrefab);
        player.transform.position = charSpawnPoint;
        player.transform.localScale = objScale;

        vCam.Follow = player.transform;
        vCam.LookAt = player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        // 마우스 입력 감지
        rotation.x += Input.GetAxis("Mouse X") * mouseSensitivity;
        rotation.y -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        rotation.y = Mathf.Clamp(rotation.y, -90f, 90f); // 수직 회전 제한

        // 캐릭터의 시야 회전 설정
        player.transform.rotation = Quaternion.Euler(0f, rotation.x, 0f);

        // Cinemachine 가상 카메라의 트랜스폼 설정
        vCam.transform.rotation = Quaternion.Euler(rotation.y, rotation.x, 0f);
    
    }
}