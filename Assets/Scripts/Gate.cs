using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gate : MonoBehaviour
{
    Animator animator;
    public AudioClip sound;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();

        GameObject obj = GameObject.FindGameObjectWithTag("Player");
        // if (obj != null )
        //{
        //obj.GetComponent<Spin>().powerUp.AddListener(OnPowerUp);
        //}
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            animator.Play("door open");
            AudioSource.PlayClipAtPoint(sound, transform.position);
            Debug.Log("just opened the door");
            Debug.Log("hittting " + other.name);
            Invoke("Transition", 3f);
        }
    }
    private void Transition()
    {
        
        SceneManager.LoadScene(1);
        
    }
   // private void OnTriggerExit(Collider other)
    //{
     //   animator.Play("close");
    //}
   // public void OnPowerUp()
    //{
        //Debug.Log("open door");
        //animator.Play("open");
    //}
   
}
