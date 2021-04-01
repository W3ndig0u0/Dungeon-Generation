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

  public float waitTime;

  private bool spawnedBoss;
  public GameObject boss;
  void Update()
  {
    // !Spawna boss
    if (waitTime <= 0 && spawnedBoss == false)
    {
      Instantiate(boss, room.transform.position, Quaternion.identity);
      spawnedBoss = true;
    }
    else
    {
      waitTime -= Time.deltaTime;
    }
  }
}
