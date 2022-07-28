using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerDoorControl : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;

    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;

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
            if (openTrigger)
            {
                myDoor.Play("doorOpen", 0, 0.0f);
                gameObject.SetActive(true);
            }
            else if (closeTrigger)
            {
                myDoor.Play("doorClose", 0, 0.0f);
                gameObject.SetActive(true);
            }
        }
    }
}
