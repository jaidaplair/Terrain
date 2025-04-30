using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackDetection : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("weapon"))
        {
            BadGuys badGuy = GetComponent<BadGuys>();
            if (badGuy != null)
            {
                badGuy.GetStunned(); // Call the GetStunned method to stun the bad guy
            }
        }
    }
}
