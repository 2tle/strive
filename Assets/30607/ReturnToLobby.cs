using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReturnToLobby : MonoBehaviour
{
    public void OnReturnButtonClicked()
    {
        SceneManager.LoadScene("LobbyScene"); 
    }
}
