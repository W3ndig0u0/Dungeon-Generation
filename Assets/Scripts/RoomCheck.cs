using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomCheck : MonoBehaviour
{
  public float waitTime = 2f;
  void Start()
  {
    Destroy(gameObject, waitTime);
  }
}
