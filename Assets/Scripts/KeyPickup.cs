using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public AudioClip ding;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerInventory inventory = other.GetComponent<PlayerInventory>();
            if (inventory != null)
            {
                inventory.hasKey = true;
                AudioSource.PlayClipAtPoint(ding, transform.position); // Play attack sound
            
            Destroy(gameObject); // Remove key from scene
            }
        }
    }
}
