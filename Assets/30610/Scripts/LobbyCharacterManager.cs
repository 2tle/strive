using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LobbyCharacterManager : MonoBehaviour
{
    public Vector3 lbSpawnPos = new Vector3(17f, -21f, 887f);
    public Button leftBtn;
    public Button rightBtn;
    public Button infoBtn;
    public Text infoText;
    public GameObject[] playerPrefabs;
    public static GameObject[] playerStaticPrefabs;
    public GameObject player;
    public string[] playersDesc;
    public static int currentPlayers = 0;
    // Start is called before the first frame update
    void Start()
    {
        leftBtn = GameObject.Find("LeftButton").GetComponent<Button>();
        rightBtn = GameObject.Find("RightButton").GetComponent<Button>();
        infoBtn = GameObject.Find("CharInfoButton").GetComponent<Button>();
        //infoText = GameObject.Find("CharInfoText").GetComponent<Text>();
        //player = GameObject.Find("PlayerCharacter").GetComponent<GameObject>();
        spawnChar(currentPlayers);
        infoText.text = "";
        infoText.gameObject.SetActive(false);

        playerStaticPrefabs = playerPrefabs;

        leftBtn.onClick.AddListener(onLeftBtnClicked);
        rightBtn.onClick.AddListener(onRightBtnClicked);
        infoBtn.onClick.AddListener(onInfoBtnClicked);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void onLeftBtnClicked()
    {
        if (currentPlayers == 0) currentPlayers = playerPrefabs.Length;
        currentPlayers--;

        spawnChar(currentPlayers);
        
    }
    private void onRightBtnClicked()
    {
        if (currentPlayers == playerPrefabs.Length - 1) currentPlayers = -1;
        currentPlayers++;

        spawnChar(currentPlayers);
    }
    private void onInfoBtnClicked()
    {
        //설명창 띄우기.
        if (infoText.gameObject.activeSelf == true) {
            infoText.gameObject.SetActive(false);
            return;
        }

        infoText.text = playersDesc[currentPlayers];
        infoText.gameObject.SetActive(true);

    }
    private void spawnChar(int pos) {
        Destroy(player);
        player = Instantiate(playerPrefabs[pos]);
        player.transform.localScale = new Vector3(100f, 100f, 100f);
        player.transform.position = lbSpawnPos;
        infoText.gameObject.SetActive(false);
    }

    public static GameObject getPlayerCharacterPrefab()
    {
        return playerStaticPrefabs[currentPlayers];
    }

}
