using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TunnelSpawn : MonoBehaviour
{
  public GameObject tunnel;
  public GameObject roomSpawn;
  private Spawn spawn;
  public int direction;
  private TunnelDelete tunnelDelete;

  void Start()
  {
    SpawnTunnel();
    TunnelDelete.amountTunnel = 0;
  }
  void Update()
  {
    print(TunnelDelete.amountTunnel);
  }
  void SpawnTunnel()
  {
    if (TunnelDelete.amountTunnel <= RoomTemplate.maxAmountRoom)
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
      TunnelDelete.amountTunnel += 1;
    }
  }

  void OnTriggerEnter2D(Collider2D other)
  {
    // !Ta bort gameobject om SpawnPoint krokar med varran.
    if (CompareTag("TunnelSpawn"))
    {
      Destroy(gameObject);
    }
  }
}
