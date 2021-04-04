using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
  public Healthbar healthbar;
  public static float health = 200;
  public float getScoreFromKill;
  public static float maxHealth = 200;
  void Awake()
  {
    health = maxHealth;
    healthbar.SetMaxHealth(maxHealth);
  }
  public static void TakeDamage(float damageAmount)
  {
    // !Skada
    health -= damageAmount;

    // !Minskar healthbar
    // healthbar.Sethealth(health);
  }
}
