using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFeed : MonoBehaviour
{
  public float destroyTime = 4f;
  void OnEnable()
  {
    Destroy(gameObject, destroyTime);
  }
}
