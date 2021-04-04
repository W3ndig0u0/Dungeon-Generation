using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteRoom : MonoBehaviour
{
  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.CompareTag("Room"))
    {
      Destroy(gameObject);
    }
  }
}
