using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
  public float waitTime = 2f;
  public int direction;
  private static int amount = 0;
  private RoomTemplate templates;
  private int random;

  private bool spawned = false;

  void Start()
  {
    // !Får tag på alla object med tagen Room
    templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplate>();

    // !Alla rooms har lika stora index så är onödigt att ha flera randoms
    random = Random.Range(0, templates.top.Length);
    RoomTemplate.maxAmountRoom = Random.Range(6, 12);
    Destroy(gameObject, waitTime);
    SpawnRoom();
  }
  void SpawnRoom()
  {
    // !Om antal rum är mindre än Max rum och att inga rum skapas nu, körs koden
    if (RoomTemplate.maxAmountRoom > amount && spawned == false)
    {
      switch (direction)
      {
        case 1:
          Instantiate(templates.room, transform.position, Quaternion.identity);
          break;

        case 2:
          Instantiate(templates.room, transform.position, Quaternion.identity);
          break;

        case 3:
          Instantiate(templates.room, transform.position, Quaternion.identity);
          break;

        case 4:
          Instantiate(templates.room, transform.position, Quaternion.identity);
          break;

        default:
          print("Error");
          break;
      }
      spawned = true;
      amount += 1;
    }
  }

  void OnTriggerEnter2D(Collider2D other)
  {
    // !Ta bort gameobject om SpawnPoint krokar med varran.
    if (CompareTag("SpawnPoint"))
    {
      // if (other.GetComponent<Spawn>().spawned == false && spawned == false)
      // {
      //   Instantiate(templates.closedRoom, transform.position, Quaternion.identity);
      // Destroy(gameObject);
      // }
      // spawned = true;
    }
  }

}