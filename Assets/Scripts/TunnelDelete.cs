using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TunnelDelete : MonoBehaviour
{
  public static int amountTunnel;
  void Start()
  {
    Destroy();
  }
  void Destroy()
  {
    // !Om Tunnlarna är mer än Max antal rum
    if (amountTunnel > RoomTemplate.maxAmountRoom)
    {
      Destroy(gameObject);
    }
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
