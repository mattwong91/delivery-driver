using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
  [SerializeField] float destroyDelay = 1f;
  bool hasPackage = false;

  void OnCollisionEnter2D(Collision2D other)
  {
    Debug.Log("BUMP");
  }

  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "Package" && !hasPackage)
    {
      Debug.Log("package picked up");
      hasPackage = true;
      Destroy(other.gameObject, destroyDelay);
    }
    if (other.tag == "Customer" && hasPackage)
    {
      Debug.Log("You delivered the package!");
      hasPackage = false;
    }
  }
}
