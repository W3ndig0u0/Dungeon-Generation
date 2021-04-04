using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  public float moveSpeed = 5f;
  public Rigidbody2D rb;
  public Camera cam;
  public Transform aim;
  public Healthbar healthbar;
  public static float health = 100, maxHealth = 100, force = 30f;
  public GameObject playerCamera, endMenuUI, bulletprefab;
  bool gameHasEnded = false;
  Vector2 mousePosition, movement;
  void Awake()
  {
    health = maxHealth;
    healthbar.SetMaxHealth(maxHealth);
  }
  void Update()
  {
    if (Input.GetButtonDown("Fire1"))
    {
      Shoot();
    }

    movement.x = Input.GetAxisRaw("Horizontal");
    movement.y = Input.GetAxisRaw("Vertical");
    mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
  }
  void FixedUpdate()
  {
    rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    Vector2 lockDir = mousePosition - rb.position;

    // !Atan retruns anle mellan xy o atan2s xy
    float angle = Mathf.Atan2(lockDir.y, lockDir.x) * Mathf.Rad2Deg - 90f;
    rb.rotation = angle;
  }
  void Shoot()
  {
    // !Skapar bullet, get den en component och lägger force
    GameObject bullet = Instantiate(bulletprefab, aim.position, aim.rotation);
    Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
    rb.AddForce(aim.up * force, ForceMode2D.Impulse);
  }

  public void TakeDamage(float damageAmount)
  {
    // !Skada
    health -= damageAmount;

    // !Minskar healthbar
    healthbar.Sethealth(health);

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
    endMenuUI.SetActive(true);
    Time.timeScale = 0f;
    gameHasEnded = true;
  }

  void OnCollisionEnter2D(Collision2D col)
  {
    if (col.gameObject.CompareTag("Enemy"))
    {
      TakeDamage(20);
      print("-20");
      // GameObject hitEffectGO = Instantiate(hitEffect, transform.position, Quaternion.identity);
    }
  }
}
