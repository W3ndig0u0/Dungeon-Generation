using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

  public GameObject effect;
  void OnCollisionEnter2D(Collision2D hit)
  {
    Destroy(gameObject, 2f);
  }
}
