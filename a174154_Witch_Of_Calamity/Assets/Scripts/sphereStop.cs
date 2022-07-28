using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereStop : MonoBehaviour
{
    public Rigidbody rb;
    int speed = 5;
    // Start is called before the first frame update
    void Start()
    {
       // rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            rb.useGravity = true;
           rb.isKinematic = false;
        }
   }

   void OnTriggerExit(Collider other)
    {
        rb.useGravity = false;
        rb.isKinematic = true;
    }
}
