using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlock : MonoBehaviour
{
    Animator animator;
    public bool isUnlocked = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        GameObject obj = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        animator.Play("door open");
        Debug.Log("just opened the door");
        if (other.CompareTag("Player"))
        {
            PlayerInventory inventory = other.GetComponent<PlayerInventory>();
            if (inventory != null && inventory.hasKey)
            {
                UnlockGate();
            }
        }
    }

    void UnlockGate()
    {
        isUnlocked = true;
        Debug.Log("Gate unlocked!");
        gameObject.SetActive(false); // Disables the gate; you can replace this with an animation
    }
}
