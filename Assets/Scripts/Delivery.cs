using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
  [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
  [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);
  [SerializeField] float destroyDelay = 1f;

  bool hasPackage = false;

  SpriteRenderer spriteRenderer;

  void Start()
  {
    spriteRenderer = GetComponent<SpriteRenderer>();
  }

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
      spriteRenderer.color = hasPackageColor;
      Destroy(other.gameObject, destroyDelay);
    }
    if (other.tag == "Customer" && hasPackage)
    {
      Debug.Log("You delivered the package!");
      hasPackage = false;
      spriteRenderer.color = noPackageColor;
    }
  }
}
