using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
  public int direction;
  private static int amountRoom = 0;
  private RoomTemplate templates;
  private int random;
  private bool spawning = false;
  void Start()
  {
    // !Får tag på alla object med tagen Room
    templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplate>();

    // !Alla rooms har lika stora index så är onödigt att ha flera randoms
    random = Random.Range(0, templates.top.Length);

    RoomTemplate.maxAmountRoom = Random.Range(5, 10);

    // !Vänta in 0.1s för att sparta SpawnRoom
    Invoke("SpawnRoom", 0.1f);
  }
  void SpawnRoom()
  {
    // !Om antal rum är mindre än Max rum och att inga rum skapas nu, körs koden
    if (RoomTemplate.maxAmountRoom > amountRoom && !spawning)
    {
      switch (direction)
      {
        case 1:
          Instantiate(templates.top[random], transform.position, Quaternion.identity);
          break;

        case 2:
          Instantiate(templates.bottom[random], transform.position, Quaternion.identity);
          break;

        case 3:
          Instantiate(templates.left[random], transform.position, Quaternion.identity);
          break;

        case 4:
          Instantiate(templates.right[random], transform.position, Quaternion.identity);
          break;

        default:
          print("Error");
          break;
      }
      amountRoom += 1;
      spawning = true;
    }
  }

  void OnTriggerEnter2D(Collider2D other)
  {
    // !Ta bort gameobject om SpawnPoint krokar med varran.
    if (CompareTag("SpawnPoint"))
    {
      Destroy(gameObject);
    }
  }

}