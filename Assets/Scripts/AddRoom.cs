using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRoom : MonoBehaviour
{
  RoomTemplate template;

  void Start()
  {
    template = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplate>();
    // !Alla rooms hamnar i listan
    template.rooms.Add(this.gameObject);
  }
}
