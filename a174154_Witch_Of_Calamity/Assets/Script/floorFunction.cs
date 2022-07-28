using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorFunction : MonoBehaviour
{
    [SerializeField] private Animator myFloor = null;
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
            myFloor.Play("upFloor", 0, 0.0f);
            
        }
    }

    void OnTriggerExit(Collider other)
    {
        myFloor.Play("New State", 0, 0.0f);
        
    }
}
