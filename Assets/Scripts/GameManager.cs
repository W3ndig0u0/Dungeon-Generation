using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
  public GameObject playerfeed;
  public GameObject feed;


  void OnPhotonPlayerConnect(PhotonPlayer player)
  {
    GameObject obj = Instantiate(playerfeed, new Vector2(0, 0), Quaternion.identity);
    obj.transform.SetParent(feed.transform, false);
    obj.GetComponent<Text>().text = player.name + "Joined The Game";
    obj.GetComponent<Text>().color = Color.green;
    print(player.name + "Joined The Game");
  }
  void OnPhotonPlayerDisconnect(PhotonPlayer player)
  {
    GameObject obj = Instantiate(playerfeed, new Vector2(0, 0), Quaternion.identity);
    obj.transform.SetParent(feed.transform, false);
    obj.GetComponent<Text>().text = player.name + "Left The Game";
    obj.GetComponent<Text>().color = Color.red;
    print(player.name + "Left The Game");
}
}
