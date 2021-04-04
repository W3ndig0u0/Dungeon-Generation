using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
  [SerializeField] string versionName = "0.0.1";
  [SerializeField] GameObject usernameMenu, connectPanel, startButton, joinButton, createButton;
  [SerializeField] InputField usernameInput, createInput;

  // !De majoriteten är tagen från internet!! men vet "ungefär" vad de gör

  public void Connect()
  {
    PhotonNetwork.ConnectUsingSettings(versionName);
  }

  void OnConnectedToMaster()
  {
    PhotonNetwork.JoinLobby(TypedLobby.Default);
    print("Connected");
  }
  void OnDisconnectedFromServer(DisconnectCause cause)
  {
    print("Disconnected");
  }

  public void ChangeUserName()
  {
    if (usernameInput.text.Length >= 1)
    {
      startButton.SetActive(true);
    }
    else
    {
      startButton.SetActive(false);
    }
  }
  public void MinimumCreate()
  {
    if (createInput.text.Length >= 1)
    {
      createButton.SetActive(true);
    }
    else
    {
      createButton.SetActive(false);
    }
  }
  public void SetUsername()
  {
    PhotonNetwork.playerName = usernameInput.text;
  }

  public void CreateGame()
  {
    PhotonNetwork.CreateRoom(createInput.text, new RoomOptions() { MaxPlayers = 0 }, null);
    print("Create Room");
  }
  public void JoinGame()
  {
    PhotonNetwork.JoinRandomRoom();
    print("Join Random Room");
  }

  void OnJoinedRoom()
  {
    PhotonNetwork.LoadLevel("Level1");
  }
}
