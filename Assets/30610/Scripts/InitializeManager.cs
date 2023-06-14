using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeManager : MonoBehaviour
{
    public Vector3 charSpawnPoint;
    public Vector3 objScale;


    // Start is called before the first frame update
    void Start()
    {
        GameObject playerPrefab = LobbyCharacterManager.getPlayerCharacterPrefab();
        GameObject player = Instantiate(playerPrefab);
        player.transform.position = charSpawnPoint;
        player.transform.localScale = objScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}