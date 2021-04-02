using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TunnelSpawn : MonoBehaviour
{
  public GameObject tunnel;
  private static int amountTunnel = -4;

  public float waitTime = 3f;
  private bool spawnedTunnel = false;


  void Start()
  {
    Destroy(gameObject, waitTime);
    SpawnTunnel();
  }
  void SpawnTunnel()
  {
    // !Fixar deta senare
    if (true)
    // if (!spawnedTunnel && RoomTemplate.maxAmountRoom > amountTunnel)
    {
      Instantiate(tunnel, transform.position, Quaternion.identity);
      Destroy(this.gameObject);
    }

    amountTunnel += 1;
    spawnedTunnel = true;
  }
}
