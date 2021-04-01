using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
  public GameObject[] DoorOpen;

  //to receive the doors you disabled on the inspector
  private void OnTriggerEnter2D(Collider2D collision)
  {
    //if the collider we created hit another room this will trigger
    for (int i = 0; i < DoorOpen.Length; i++)
    {
      DoorOpen[i].gameObject.SetActive(true);
      //the doors we setted to disable will be enabled
    }
  }
}
