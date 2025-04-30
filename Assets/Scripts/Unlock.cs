using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlock : MonoBehaviour
{
    private Animator animator;
    public bool isUnlocked = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isUnlocked) return;

        if (other.CompareTag("Player"))
        {
            PlayerInventory inventory = other.GetComponent<PlayerInventory>();
            if (inventory != null && inventory.hasKey)
            {
                animator.Play("door open");
                UnlockGate();
                Debug.Log("just opened the door");
            }
            else
            {
                Debug.Log("You need a key to open this door.");
            }
        }
    }

    void UnlockGate()
    {
        isUnlocked = true;
        Debug.Log("Gate unlocked!");
        // Optionally disable collider if you don’t want it to trigger again:
        // GetComponent<Collider>().enabled = false;
    }
}

