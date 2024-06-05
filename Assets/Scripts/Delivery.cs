using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
  void OnCollisionEnter2D(Collision2D other)
  {
    Debug.Log($"{name} bumped into {other.gameObject.name}");
  }

  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "Package")
    {
      Debug.Log("package picked up");
    }
    if (other.tag == "Customer")
    {
      Debug.Log("You delivered the package!");
    }
  }
}
