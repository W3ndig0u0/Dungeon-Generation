using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
  public float moveSpeed = 5f;
  public Rigidbody2D rb;
  public Camera cam;
  Vector2 mousePosition;
  Vector2 movement;

  void Update()
  {
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
}
