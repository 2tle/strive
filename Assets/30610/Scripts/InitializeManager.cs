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
        
    }
}