using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

  //   public HealthBar healthbar;
  public static float health;
  public float maxHealth = 100;
  public GameObject hitEffect;
  bool gameHasEnded = false;

  public GameObject endMenuUI;

  void Start()
  {
    // !Sätter max liv o Health bar
    health = maxHealth;
    // healthbar.SetMaxHealth(maxHealth);
  }
  void OnCollisionEnter(Collision col)
  {
    if (col.gameObject.CompareTag("Enemy"))
    {
      TakeDamage(20);
      GameObject hitEffectGO = Instantiate(hitEffect, transform.position, Quaternion.identity);
    }
  }
  public void TakeDamage(float damageAmount)
  {
    // !Skada
    // health -= damageAmount;

    // // !Minskar healthbar
    // healthbar.SetHealth(health);

    if (health <= 0f)
    {
      GameOver();
    }
  }
  void GameOver()
  {
    if (gameHasEnded == false)
    {
      print("ed");
      gameHasEnded = true;
      EndSceen();
    }
  }
  public void EndSceen()
  {
    // endMenuUI.SetActive(true);
    Time.timeScale = 0f;
    gameHasEnded = true;
    Cursor.lockState = CursorLockMode.None;
    Cursor.visible = true;
  }

  void OnCollisionEnter2D(Collision2D ground)
  {
    if (ground.gameObject.tag == "Ground")
    {
      print("Sorry");
    }
  }
}
