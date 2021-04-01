using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TunnelSpawn : MonoBehaviour
{
  public GameObject tunnel;
  public int direction;
  private static int amountTunnel = -5;

  public float waitTime = 3f;
  private TunnelDelete tunnelDelete;
  private bool spawnedTunnel = false;

  void Start()
  {
    Destroy(gameObject, waitTime);
    SpawnTunnel();
  }
  void Update()
  {
    Debug.Log(RoomTemplate.maxAmountRoom);
  }
  void SpawnTunnel()
  {
    // if (true)
    if (!spawnedTunnel && RoomTemplate.maxAmountRoom > amountTunnel)
    {
      switch (direction)
      {
        case 1:
          Instantiate(tunnel, transform.position, Quaternion.identity);
          break;

        case 2:
          Instantiate(tunnel, transform.position, Quaternion.identity);
          break;

        case 3:
          Instantiate(tunnel, transform.position, Quaternion.identity);
          break;

        case 4:
          Instantiate(tunnel, transform.position, Quaternion.identity);
          break;

        default:
          print("Error");
          break;
      }
      amountTunnel += 1;
      spawnedTunnel = true;
    }
  }

  void OnTriggerEnter2D(Collider2D other)
  {
    Destroy(gameObject);
  }
}
