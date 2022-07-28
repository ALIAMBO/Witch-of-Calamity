using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorFunction : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myDoor.Play("opendoor", 0, 0.0f);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myDoor.Play("closedoor", 0, 0.0f);
        }
        
    }
}
