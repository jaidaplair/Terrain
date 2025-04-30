using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        if (animator == null)
        {
            Debug.LogError("Animator not found on " + gameObject.name);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.Play("gate open");
            Debug.Log("Gate opening.");
        }
    }

    private void OnTriggerExit(Collider other)
    {
       // if (other.CompareTag("Player"))
        //{
            animator.Play("gate closed");
            Debug.Log("Gate closing.");
        //}
    }
}
