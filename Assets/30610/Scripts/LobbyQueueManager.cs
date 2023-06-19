using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LobbyQueueManager : MonoBehaviour
{
    public Button gameStartBtn;
    public Button tutorialBtn;
    // Start is called before the first frame update
    void Start()
    {
        gameStartBtn = GameObject.Find("GameStartButton").GetComponent<Button>();
        tutorialBtn = GameObject.Find("TutorialButton").GetComponent<Button>();

        gameStartBtn.onClick.AddListener(onGameStartBtnClicked);
        tutorialBtn.onClick.AddListener(onTutorialBtnClicked);
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    private void onGameStartBtnClicked()
    {
        SceneManager.LoadScene("Map2Scene");
    }

    private void onTutorialBtnClicked() {
        SceneManager.LoadScene("Map 3");
        //SceneManager.LoadScene("Stage11");
    }

    //private GameObject getGameCharacterPrefabs() {
    //    return LobbyCharacterManager.getPlayerCharacterPrefab();
    //}
}
