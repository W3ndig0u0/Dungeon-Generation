using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TunnelDelete : MonoBehaviour
{
  void OnTriggerEnter2D(Collider2D tunnel)
  {
    if (tunnel.CompareTag("Tunnel"))
    {
      // Destroy(this.gameObject);
    }
  }
}
