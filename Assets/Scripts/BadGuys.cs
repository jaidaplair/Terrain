using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuys : MonoBehaviour
{
    [SerializeField] Transform ObjectToLookAT;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookVector = new Vector3(ObjectToLookAT.position.x, transform.position.y, ObjectToLookAT.position.z);
        transform.LookAt(ObjectToLookAT);

    }
}
