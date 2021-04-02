using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
  public GameObject DoorOpen;
  private void OnTriggerEnter2D(Collider2D door)
  {
    // if (gameObject.tag == "Tunnel")
    // {
    //   Destroy(gameObject);
    // gameObject.SetActive(false);
    // }
  }
}
