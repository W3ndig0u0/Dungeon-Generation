using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
  public float force = 30f;
  public Transform aim;
  public GameObject bulletprefab;
  // Update is called once per frame
  void Update()
  {
    if (Input.GetButton("Fire1"))
    {
      Shoot();
    }
  }
  void Shoot()
  {
    // !Skapar bullet, get den en component och lägger force
    GameObject bullet = Instantiate(bulletprefab, aim.position, aim.rotation);
    Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
    rb.AddForce(aim.up * force, ForceMode2D.Impulse);
  }
}
