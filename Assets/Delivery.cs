using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float destoryDelay;
    bool hasPackage;

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Hit!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package is picked up.");
            hasPackage = true;

            Destroy(other.gameObject, destoryDelay);
        }

        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("delivered package.");
            hasPackage = false;
        }
    }
}
