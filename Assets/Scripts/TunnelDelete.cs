using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TunnelDelete : MonoBehaviour
{
  public static int amountTunnel;
  void Update()
  {
    Destroy();
  }
  void Destroy()
  {
    // !Om Tunnlarna är mer än Max antal rum
    // if (RoomTemplate.maxAmountRoom > 0)
    // {
    //   Destroy(gameObject);
    // }
  }
  void OnTriggerEnter2D(Collider2D other)
  {
    // !Om tunnlar nuddar varran
    if (other.CompareTag("Tunnel"))
    {
      Destroy(gameObject);
    }
  }
}
