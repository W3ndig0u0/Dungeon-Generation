using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTemplate : MonoBehaviour
{
  // !En Room class 
  public GameObject[] bottom, top, left, right;

  public GameObject leftRight, upBottom;
  public static int maxAmountRoom;

  public GameObject closedRoom;
  public List<GameObject> rooms;

  public GameObject room;

  public float waitTime = 20;

  private bool spawnedBoss;
  public GameObject boss;
  void Update()
  {
    // !Spawna boss
    if (waitTime <= 0)
    {
      Instantiate(boss, rooms[rooms.Count - 1].transform.position, Quaternion.identity);
      waitTime = 20;
    }
    else
    {
      waitTime -= Time.deltaTime;
    }
  }
}
