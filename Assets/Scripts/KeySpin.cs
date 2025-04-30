using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeySpin : MonoBehaviour
{
    public UnityEvent powerUp;
    [SerializeField] float speed = 360f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(speed * Time.deltaTime * Vector3.forward);
        // Find all gates and subscribe them to the powerUp event
        Gate[] gates = FindObjectsOfType<Gate>();
       // foreach (Gate gate in gates)
       // {
            //powerUp.AddListener(gate.OnPowerUp);
       // }
    }

    private void OnTriggerEnter(Collider other)
    {
        //powerUp.Invoke();

        if (other.CompareTag("Player"))
        {
            // powerUp.Invoke(); // Open all gates

            Debug.Log("got key");
            Destroy(gameObject); // Remove the coin after activation
        }
    }
}
