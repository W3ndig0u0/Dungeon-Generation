using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

  public Target target;
  public ParticleSystem effect;
  void OnCollisionEnter2D(Collision2D hit)
  {
    if (hit.gameObject.CompareTag("Enemy"))
    {
      print("ouch");
      Target.TakeDamage(10f);
      Destroy(gameObject, 1f);
      if (Target.health >= 0f)
      {
        Destroy(hit.gameObject);
        Target.health = Target.maxHealth;
        // Spawn.enemies -= 1;
        // print(Spawn.enemies);
      }
    }
  }
}
