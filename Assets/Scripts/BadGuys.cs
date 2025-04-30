using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuys : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private float stunDuration = 3f; // How long bad guys stay stunned
    private Animator animator;
    private bool isStunned = false;

    public AudioClip hurtSound;
    //public AudioClip audioSource;



    void Start()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform; // Find the player
        }
    }

    void Update()
    {
        if (!isStunned)
        {
            PursuePlayer();
        }
       
    }

    void PursuePlayer()
    {
        // Make the bad guy look at the player
        Vector3 direction = player.position - transform.position;
        direction.y = 0; // Keep it on the XZ plane (no looking up or down)
        transform.LookAt(player.position);

        // Move towards the player
        //transform.Translate(direction.normalized * moveSpeed * Time.deltaTime, Space.World);
    }

    // Call this method when the bad guy gets hit by the player's weapon
    public void GetStunned()
    {
        if (!isStunned)
        {
            isStunned = true;
            animator.SetTrigger("stunned"); // Play the stun animation
            animator.Play("stunned");
            AudioSource.PlayClipAtPoint(hurtSound, transform.position); // Play hurt sound
            
            StartCoroutine(RecoverFromStun());
        }
    }

    IEnumerator RecoverFromStun()
    {
        yield return new WaitForSeconds(stunDuration); // Wait for the stun duration
        animator.SetTrigger("Recover"); // Play recovery animation
        isStunned = false;
    }
}

