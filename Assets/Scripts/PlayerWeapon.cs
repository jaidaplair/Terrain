using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    public Transform weaponHand; // Where the weapon should be attached to
    public GameObject weaponPrefab; // The weapon prefab to be instantiated

    private Animator animator;
    public AudioClip attackSound;  // Attack sound

    void Start()
    {
        animator = GetComponent<Animator>();

        // Attach the weapon to the player's hand
        //AttachWeapon();
    }

   // void AttachWeapon()
   // {
    //    GameObject weapon = Instantiate(weaponPrefab, weaponHand.position, weaponHand.rotation);
      //  weapon.transform.SetParent(weaponHand);
  //  }

    void Update()
    {
        // Trigger the attack animation when the player presses the attack button (e.g., spacebar)
        if (Input.GetKeyDown(KeyCode.E)) // Default for Fire1 is left mouse button
        {
            animator.SetTrigger("Mele");// Trigger the attack animation
            animator.Play("mele");
            Attack();
        }
    }

    void Attack()
    {
        animator.SetTrigger("mele");// Trigger the attack animation
        AudioSource.PlayClipAtPoint(attackSound, transform.position); // Play attack sound
    }
}
